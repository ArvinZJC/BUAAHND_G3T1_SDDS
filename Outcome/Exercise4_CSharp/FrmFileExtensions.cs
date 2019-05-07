/*
 * @Description: csharp file mainly for control events of the form
 * @Version: 1.5.0.0
 * @Author: Arvin Zhao
 * @Date: 2018-12-04 22:05:52
 * @Last Editors: Arvin Zhao
 * @LastEditTime: 2018-12-09 10:26:54
 */

#region Using Directives
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
#endregion Using Directives

namespace Exercise4_CSharp
{
    /// <summary>
    /// Extending from class Form, the partial class <see cref="FrmFileExtensions"/> contains control events of the form and relevant methods.
    /// </summary>
    public partial class FrmFileExtensions : Form
    {
        #region Members
        private static readonly FileStream datafile = new FileStream(Application.StartupPath + @"\datafile.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite); // the file stream for the data file "datafile.dat"
        private static readonly BinaryFormatter binaryData = new BinaryFormatter(); // a binary formatter for serialising and deserialising data
        private static Dictionary<string, string> entryList; // a dictionary for displaying specified entries
        private static readonly Dictionary<string, string> allEntries = new Dictionary<string, string>(); // a dictionary for recording all entries
        private static string contents = string.Empty; // a string containing data deserilised
        private static string entryDeleted = string.Empty; // a string containing the file extension of the entry deleted
        private static readonly string regexForExtension = "^[.][A-Za-z0-9]+$"; // a regular expression for a file extension
        private static readonly string regexForDefaultProgram = "^[A-Za-z0-9]+$"; // a regular expression for a default program
        private static string[] data; // store data groups (a file extension=a default program) converted from "contents"
        #endregion Members

        #region Constructor
        /// <summary>
        /// Non-parameter constructor that initialises controls on the form.
        /// </summary>
        public FrmFileExtensions()
        {
            InitializeComponent();
        } // end constructor FrmFileExtensions
        #endregion Constructor

        #region Private Methods
        // specify a universal status selection for specified controls
        private void MostControlsUniversalStatus(int selection)
        {
            switch (selection)
            {
                case 1:
                    WtxtAddFileExtension.Enabled = true;
                    WtxtAddFileExtension.Text = string.Empty;
                    WtxtAddDefaultProgram.Enabled = true;
                    WtxtAddDefaultProgram.Text = string.Empty;
                    break;

                case 2:
                    LblNoticeForAdding.Text = string.Empty;
                    LblNoticeForDeleting.Text = string.Empty;
                    break;

                case 3:
                    WtxtFindFileExtension.Text = string.Empty;
                    WtxtFindFileExtension.Enabled = false;
                    BtnListAll.Enabled = false;
                    BtnClearAll.Enabled = false;
                    break;

                case 4:
                    BtnFindDefaultProgram.Enabled = false;
                    BtnDeleteCurrentEntry.Enabled = false;
                    break;
                
                default:
                    MessageBox.Show("Error! Something wrong during the process of specifying a universal status selection for specified controls.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            } // end switch-case
        } // end method MostControlsUniversalStatus

        // specifiy a status selection for the control "LblProgramNotice"
        private void LblProgramNoticeMessage(int selection)
        {
            switch (selection)
            {
                case 1:
                    LblProgramNotice.ForeColor = Color.DarkOrange;
                    LblProgramNotice.Text = "ATTENTION! Do not modify data in the file \"datafile.dat\"!";
                    break;

                case 2:
                    LblProgramNotice.ForeColor = Color.DarkOrange;
                    LblProgramNotice.Text = "Tip: Entry data not as expected? Try to clear all.";
                    break;

                case 3:
                    LblProgramNotice.ForeColor = Color.Red;
                    LblProgramNotice.Text = "Error! Entry data destroyed. Try to clear all.";
                    break;

                default:
                    MessageBox.Show("Error! Something wrong during the process of selecting a program notice.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            } // end switch-case
        } // end method LblProgramNoticeMessage

        // specifiy a status selection for the control "LblNoticeForAdding"
        private void LblNoticeForAddingMessage(int selection)
        {
            switch (selection)
            {
                case 1:
                    LblNoticeForAdding.ForeColor = Color.Green;
                    LblNoticeForAdding.Text = "Entry added successfully.";
                    break;

                case 2:
                    LblNoticeForAdding.ForeColor = Color.DarkOrange;
                    LblNoticeForAdding.Text = "Warning! Entry with \"" + WtxtAddFileExtension.Text.Trim() + "\" already exists.";
                    break;

                case 3:
                    LblNoticeForAdding.ForeColor = Color.Red;
                    LblNoticeForAdding.Text = "Illegal file extension! Forgot to start with \".\"? Not complete? Spaces?";
                    break;

                case 4:
                    LblNoticeForAdding.ForeColor = Color.Red;
                    LblNoticeForAdding.Text = "Illegal default program! Special characters? Spaces?";
                    break;

                default:
                    MessageBox.Show("Error! Something wrong during the process of selecting a notice for adding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            } // end switch-case
        } // end method LblNoticeForAddingMessage

        // specifiy a status selection for the control "LblNoticeForDeleting"
        private void LblNoticeForDeletingMessage(int selection)
        {
            switch (selection)
            {
                case 1:
                    LblNoticeForDeleting.ForeColor = Color.Green;
                    LblNoticeForDeleting.Text = "Entry found successfully.";
                    break;

                case 2:
                    LblNoticeForDeleting.ForeColor = Color.Green;
                    LblNoticeForDeleting.Text = "Entry for \"" + entryDeleted + "\" deleted successfully.";
                    break;

                case 3:
                    LblNoticeForDeleting.ForeColor = Color.Red;
                    LblNoticeForDeleting.Text = "Illegal file extension! Forgot to start with \".\"? Not complete? Spaces?";
                    break;

                case 4:
                    LblNoticeForDeleting.ForeColor = Color.Red;
                    LblNoticeForDeleting.Text = "No entry with the file extension \"" + WtxtFindFileExtension.Text.Trim() + "\", so nothing for deleting.";
                    break;

                default:
                    MessageBox.Show("Error! Something wrong during the process of selecting a notice for deleting.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            } // end switch-case
        } // end method LblNoticeForDeletingMessage

        // load all entries recorded
        private void LoadAllEntries()
        {
            foreach (string eachData in data)
            {
                if (eachData.Length > 0)
                {
                    string[] eachColumn = eachData.Split('='); // store the file extension at Index 0 and the default program at Index 1 for each data group (a file extension=a default program)

                    try
                    {
                        allEntries.Add(eachColumn[0], eachColumn[1]);
                    }
                    // a loading error probably caused by a destroyed data file
                    catch (ArgumentException)
                    {
                        LblProgramNoticeMessage(3); // call the specified method to specifiy a status selection for the control "LblProgramNotice"
                        WtxtAddFileExtension.Enabled = false;
                        WtxtAddDefaultProgram.Enabled = false;
                        WtxtFindFileExtension.Enabled = false;
                        BtnListAll.Enabled = false;
                    } // end try...catch
                } // end if
            } // end foreach
        } // end method LoadAllEntries

        // display the specified entries in the control "DataGridViewEntryList"
        private DataTable DisplayEntryList()
        {
            DataTable table = new DataTable();
            DataColumn column1 = new DataColumn("File Extension");
            DataColumn column2 = new DataColumn("Default Program");

            table.Columns.Add(column1);
            table.Columns.Add(column2);

            foreach (KeyValuePair<string, string> keyAndValue in entryList)
            {
                DataRow row = table.NewRow();

                row[0] = keyAndValue.Key; // a file extension
                row[1] = keyAndValue.Value; // a default program

                table.Rows.Add(row);
            } // end foreach

            return table;
        } // end method DisplayEntryList

        // set the action of the text boxes in the area "Add Entry"
        private void AddEntryTextBoxAction()
        {
            MostControlsUniversalStatus(2); // call the specified method to specify a universal status selection for specified controls
            LblProgramNoticeMessage(1); // call the specified method to specifiy a status selection for the control "LblProgramNotice"

            if (WtxtAddFileExtension.Text.Trim().Length > 0)
            {
                if (Regex.IsMatch(WtxtAddFileExtension.Text.Trim(), regexForExtension))
                {
                    if (allEntries.ContainsKey(WtxtAddFileExtension.Text.Trim()))
                    {
                        BtnAddNewEntry.Enabled = false;
                        LblNoticeForAddingMessage(2); // call the specified method to specifiy a status selection for the control "LblNoticeForAdding"
                    }
                    else if (WtxtAddDefaultProgram.Text.Trim().Length > 0)
                    {
                        if (Regex.IsMatch(WtxtAddDefaultProgram.Text.Trim(), regexForDefaultProgram))
                            BtnAddNewEntry.Enabled = true;
                        else
                        {
                            BtnAddNewEntry.Enabled = false;
                            LblNoticeForAddingMessage(4); // call the specified method to specifiy a status selection for the control "LblNoticeForAdding"
                        } // end if...else
                    }
                    else
                        BtnAddNewEntry.Enabled = false;
                }
                else
                {
                    BtnAddNewEntry.Enabled = false;
                    LblNoticeForAddingMessage(3); // call the specified method to specifiy a status selection for the control "LblNoticeForAdding"
                } // end if...else
            }
            else
            {
                BtnAddNewEntry.Enabled = false;

                if (WtxtAddDefaultProgram.Text.Trim().Length > 0 && !Regex.IsMatch(WtxtAddDefaultProgram.Text.Trim(), regexForDefaultProgram))
                    LblNoticeForAddingMessage(4); // call the specified method to specifiy a status selection for the control "LblNoticeForAdding"
            } // end if...else
        } // end method AddEntryTextBoxAction

        // clear data in the data file
        private void ClearDataFile()
        {
            datafile.Seek(0, SeekOrigin.Begin);
            datafile.SetLength(0);
        } // end method ClearDataFile
        #endregion Private Methods

        #region Control Events
        // execute when the form is loaded
        private void FrmFileExtensions_Load(object sender, EventArgs e)
        {
            if (datafile.Length > 0)
            {
                // loop to get all data in the data file
                while (true)
                {
                    try
                    {
                        contents += (string)binaryData.Deserialize(datafile);
                    }
                    // break the loop when it reaches the end of the data file
                    catch (SerializationException)
                    {
                        break;
                    } // end try...catch
                } // end while
                
                data = contents.Split('|');
                LoadAllEntries(); // call the specified method to load all entries recorded.
            }
            else
                MostControlsUniversalStatus(3); // call the specified method to specify a universal status selection for specified controls

            MostControlsUniversalStatus(2); // call the specified method to specify a universal status selection for specified controls
            MostControlsUniversalStatus(4); // call the specified method to specify a universal status selection for specified controls
            BtnAddNewEntry.Enabled = false;
        } // end method FrmFileExtensions_Load

        // close the file stream to try to avoid resource leak or any other problem before completely exiting the program
        private void FrmFileExtensions_FormClosing(object sender, FormClosingEventArgs e)
        {
            datafile.Close();
        } // end method FrmFileExtensions_FormClosing

        #region Title Bar
        // minimise the form when the specified button is clicked on
        private void BtnMinimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        } // end method BtnMinimise_Click

        // completely exit the program when the specified button is clicked on
        private void BtnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        } // end method BtnClose_Click
        #endregion Title Bar

        #region Add Entry
        // execute when the text in the control "WtxtAddFileExtension" is changed
        private void WtxtAddFileExtension_TextChanged(object sender, EventArgs e)
        {
            AddEntryTextBoxAction(); // call the specified method to set the action of the text boxes in the area "Add Entry"
        } // end method WtxtAddFileExtension_TextChanged

        // execute when the text in the control "WtxtAddDefaultProgram" is changed
        private void WtxtAddDefaultProgram_TextChanged(object sender, EventArgs e)
        {
            AddEntryTextBoxAction(); // call the specified method to set the action of the text boxes in the area "Add Entry"
        } // end method WtxtAddDefaultProgram_TextChanged

        // execute when the control "BtnAddNewEntry" is enabled and clicked
        private void BtnAddNewEntry_Click(object sender, EventArgs e)
        {
            string newEntry = WtxtAddFileExtension.Text.Trim() + "=" + WtxtAddDefaultProgram.Text.Trim() + "|"; // record the entry to be added

            // add the new entry
            contents += newEntry;
            binaryData.Serialize(datafile, newEntry);

            // prepare an entry list
            data = newEntry.Split('|');
            entryList = new Dictionary<string, string>();

            // fill the entry list
            foreach (string eachData in data)
            {
                if (eachData.Length > 0)
                {
                    string[] eachColumn = eachData.Split('=');
                    entryList.Add(eachColumn[0], eachColumn[1]);
                } // end if
            } // end foreach

            LoadAllEntries(); // call the specified method to load all entries recorded

            MostControlsUniversalStatus(1); // call the specified method to specify a universal status selection for specified controls
            LblProgramNoticeMessage(1); // call the specified method to specifiy a status selection for the control "LblProgramNotice"
            LblNoticeForAddingMessage(1); // call the specified method to specifiy a status selection for the control "LblNoticeForAdding"
            DataGridViewEntryList.DataSource = DisplayEntryList(); // call the specified method to display the specified entries in the control "DataGridViewEntryList"
            WtxtFindFileExtension.Enabled = true;
            BtnListAll.Enabled = true;
            BtnClearAll.Enabled = true;
        } // end method BtnAddNewEntry_Click
        #endregion Add Entry

        #region Delete Entry
        // execute when the text in the control "WtxtFindFileExtension" is changed
        private void WtxtFindFileExtension_TextChanged(object sender, EventArgs e)
        {
            MostControlsUniversalStatus(2); // call the specified method to specify a universal status selection for specified controls
            LblProgramNoticeMessage(1); // call the specified method to specifiy a status selection for the control "LblProgramNotice"

            if (WtxtFindFileExtension.Text.Trim().Length > 0)
            {
                if (Regex.IsMatch(WtxtFindFileExtension.Text.Trim(), regexForExtension))
                    BtnFindDefaultProgram.Enabled = true;
                else
                {
                    MostControlsUniversalStatus(4); // call the specified method to specify a universal status selection for specified controls
                    LblNoticeForDeletingMessage(3); // call the specified method to specifiy a status selection for the control "LblNoticeForDeleting"
                } // end if...else
            }
            else
                MostControlsUniversalStatus(4); // call the specified method to specify a universal status selection for specified controls
        } // end method WtxtFindFileExtension_TextChanged

        // execute when the control "BtnFindDefaultProgram" is enabled and clicked
        private void BtnFindDefaultProgram_Click(object sender, EventArgs e)
        {
            if (allEntries.ContainsKey(WtxtFindFileExtension.Text.Trim()))
            {
                // prepare and fill an entry list
                entryList = new Dictionary<string, string>
                {
                    { WtxtFindFileExtension.Text.Trim(), allEntries[WtxtFindFileExtension.Text.Trim()] }
                };

                LblNoticeForDeletingMessage(1); // call the specified method to specifiy a status selection for the control "LblNoticeForDeleting"
                DataGridViewEntryList.DataSource = DisplayEntryList(); // call the specified method to display the specified entries in the control "DataGridViewEntryList"
                BtnDeleteCurrentEntry.Enabled = true;
            }
            else
            {
                LblNoticeForDeletingMessage(4); // call the specified method to specifiy a status selection for the control "LblNoticeForDeleting"
                DataGridViewEntryList.DataSource = null;
                WtxtFindFileExtension.Select();
                BtnFindDefaultProgram.Enabled = false;
            } // end if...else
        } // end method BtnFindDefaultProgram_Click

        // execute when the control "BtnDeleteCurrentEntry_Click" is enabled and clicked
        private void BtnDeleteCurrentEntry_Click(object sender, EventArgs e)
        {
            entryDeleted = WtxtFindFileExtension.Text.Trim();
            WtxtFindFileExtension.Text = string.Empty;
            contents = string.Empty;
            allEntries.Remove(entryDeleted); // delete the specified entry

            // sync the change to the string containing data deserilised
            foreach (KeyValuePair<string, string> keyAndValue in allEntries)
            {
                string eachEntry = keyAndValue.Key + "=" + keyAndValue.Value + "|";
                contents += eachEntry;
            } // end foreach

            // sync the change to the data file
            ClearDataFile(); // call the specified method to clear data in the data file
            binaryData.Serialize(datafile, contents);

            LblNoticeForDeletingMessage(2); // call the specified method to specifiy a status selection for the control "LblNoticeForDeleting"
            DataGridViewEntryList.DataSource = null;
        } // end method BtnDeleteCurrentEntry_Click
        #endregion Delete Entry

        // execute when the control "BtnListAll" is enabled and clicked
        private void BtnListAll_Click(object sender, EventArgs e)
        {
            entryList = allEntries; // prepare and fill an entry list

            MostControlsUniversalStatus(2); // call the specified method to specify a universal status selection for specified controls
            LblProgramNoticeMessage(2); // call the specified method to specifiy a status selection for the control "LblProgramNotice"
            DataGridViewEntryList.DataSource = DisplayEntryList(); // call the specified method to display the specified entries in the control "DataGridViewEntryList"
        } // end method BtnListAll_Click

        // execute when the control "BtnClearAll" is enabled and clicked
        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            // execute if the user confirms to clear all
            if (MessageBox.Show("These changes will be lost if you proceed.\nAre you sure to clear all?", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                contents = string.Empty;
                allEntries.Clear();
                ClearDataFile(); // call the specified method to clear data in the data file

                MostControlsUniversalStatus(1); // call the specified method to specify a universal status selection for specified controls
                MostControlsUniversalStatus(2); // call the specified method to specify a universal status selection for specified controls
                MostControlsUniversalStatus(3); // call the specified method to specify a universal status selection for specified controls
                MostControlsUniversalStatus(4); // call the specified method to specify a universal status selection for specified controls
                LblProgramNoticeMessage(1); // call the specified method to specifiy a status selection for the control "LblProgramNotice"
                DataGridViewEntryList.DataSource = null;

                MessageBox.Show("All Entries Successfully cleared.", Application.ProductName, MessageBoxButtons.OK);
            } // end if
        } // end method BtnClearAll_Click
        #endregion Control Events
    } // end partial class FrmFileExtensions
} // end namespace Exercise4_CSharp