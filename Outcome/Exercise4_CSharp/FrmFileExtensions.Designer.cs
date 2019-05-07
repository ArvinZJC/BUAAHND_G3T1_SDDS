using System.ComponentModel;

namespace Exercise4_CSharp
{
    partial class FrmFileExtensions
    {
        private IContainer components = null; // required designer variable

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            
            base.Dispose(disposing);
        }

        #region Windows Form Designer Generated Code
        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFileExtensions));
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.BtnMinimise = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnListAll = new System.Windows.Forms.Button();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.BtnAddNewEntry = new System.Windows.Forms.Button();
            this.BtnDeleteCurrentEntry = new System.Windows.Forms.Button();
            this.BtnFindDefaultProgram = new System.Windows.Forms.Button();
            this.GroupBoxAddEntry = new System.Windows.Forms.GroupBox();
            this.LblNoticeForAdding = new System.Windows.Forms.Label();
            this.GroupBoxDeleteEntry = new System.Windows.Forms.GroupBox();
            this.LblNoticeForDeleting = new System.Windows.Forms.Label();
            this.DataGridViewEntryList = new System.Windows.Forms.DataGridView();
            this.LblProgramNotice = new System.Windows.Forms.Label();
            this.WtxtAddFileExtension = new Exercise4_CSharp.WatermarkTextBox();
            this.WtxtAddDefaultProgram = new Exercise4_CSharp.WatermarkTextBox();
            this.WtxtFindFileExtension = new Exercise4_CSharp.WatermarkTextBox();
            this.PanelTitleBar.SuspendLayout();
            this.GroupBoxAddEntry.SuspendLayout();
            this.GroupBoxDeleteEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEntryList)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTitleBar.BackColor = System.Drawing.Color.Black;
            this.PanelTitleBar.Controls.Add(this.BtnMinimise);
            this.PanelTitleBar.Controls.Add(this.LblTitle);
            this.PanelTitleBar.Controls.Add(this.BtnClose);
            this.PanelTitleBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(1280, 44);
            this.PanelTitleBar.TabIndex = 0;
            // 
            // BtnMinimise
            // 
            this.BtnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMinimise.FlatAppearance.BorderSize = 0;
            this.BtnMinimise.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnMinimise.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimise.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimise.ForeColor = System.Drawing.Color.White;
            this.BtnMinimise.Location = new System.Drawing.Point(1160, 0);
            this.BtnMinimise.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimise.Name = "BtnMinimise";
            this.BtnMinimise.Size = new System.Drawing.Size(60, 44);
            this.BtnMinimise.TabIndex = 0;
            this.BtnMinimise.TabStop = false;
            this.BtnMinimise.Text = "–";
            this.BtnMinimise.UseVisualStyleBackColor = false;
            this.BtnMinimise.Click += new System.EventHandler(this.BtnMinimise_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(11, 9);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(175, 27);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "File Extensions";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(1220, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(60, 44);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "×";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnListAll
            // 
            this.BtnListAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListAll.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnListAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnListAll.FlatAppearance.BorderSize = 2;
            this.BtnListAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnListAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListAll.Location = new System.Drawing.Point(646, 668);
            this.BtnListAll.Name = "BtnListAll";
            this.BtnListAll.Size = new System.Drawing.Size(308, 40);
            this.BtnListAll.TabIndex = 0;
            this.BtnListAll.TabStop = false;
            this.BtnListAll.Text = "List All";
            this.BtnListAll.UseVisualStyleBackColor = false;
            this.BtnListAll.Click += new System.EventHandler(this.BtnListAll_Click);
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearAll.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnClearAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnClearAll.FlatAppearance.BorderSize = 2;
            this.BtnClearAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearAll.Location = new System.Drawing.Point(960, 668);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(308, 40);
            this.BtnClearAll.TabIndex = 0;
            this.BtnClearAll.TabStop = false;
            this.BtnClearAll.Text = "Clear All";
            this.BtnClearAll.UseVisualStyleBackColor = false;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // BtnAddNewEntry
            // 
            this.BtnAddNewEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddNewEntry.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnAddNewEntry.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnAddNewEntry.FlatAppearance.BorderSize = 2;
            this.BtnAddNewEntry.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAddNewEntry.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnAddNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAddNewEntry.Location = new System.Drawing.Point(167, 173);
            this.BtnAddNewEntry.Name = "BtnAddNewEntry";
            this.BtnAddNewEntry.Size = new System.Drawing.Size(279, 40);
            this.BtnAddNewEntry.TabIndex = 0;
            this.BtnAddNewEntry.TabStop = false;
            this.BtnAddNewEntry.Text = "Add New Entry";
            this.BtnAddNewEntry.UseVisualStyleBackColor = false;
            this.BtnAddNewEntry.Click += new System.EventHandler(this.BtnAddNewEntry_Click);
            // 
            // BtnDeleteCurrentEntry
            // 
            this.BtnDeleteCurrentEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteCurrentEntry.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnDeleteCurrentEntry.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnDeleteCurrentEntry.FlatAppearance.BorderSize = 2;
            this.BtnDeleteCurrentEntry.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDeleteCurrentEntry.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnDeleteCurrentEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteCurrentEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDeleteCurrentEntry.Location = new System.Drawing.Point(167, 189);
            this.BtnDeleteCurrentEntry.Name = "BtnDeleteCurrentEntry";
            this.BtnDeleteCurrentEntry.Size = new System.Drawing.Size(279, 40);
            this.BtnDeleteCurrentEntry.TabIndex = 0;
            this.BtnDeleteCurrentEntry.TabStop = false;
            this.BtnDeleteCurrentEntry.Text = "Delete Current Entry";
            this.BtnDeleteCurrentEntry.UseVisualStyleBackColor = false;
            this.BtnDeleteCurrentEntry.Click += new System.EventHandler(this.BtnDeleteCurrentEntry_Click);
            // 
            // BtnFindDefaultProgram
            // 
            this.BtnFindDefaultProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFindDefaultProgram.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnFindDefaultProgram.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnFindDefaultProgram.FlatAppearance.BorderSize = 2;
            this.BtnFindDefaultProgram.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnFindDefaultProgram.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnFindDefaultProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFindDefaultProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnFindDefaultProgram.Location = new System.Drawing.Point(167, 119);
            this.BtnFindDefaultProgram.Name = "BtnFindDefaultProgram";
            this.BtnFindDefaultProgram.Size = new System.Drawing.Size(279, 40);
            this.BtnFindDefaultProgram.TabIndex = 0;
            this.BtnFindDefaultProgram.TabStop = false;
            this.BtnFindDefaultProgram.Text = "Find Default Program";
            this.BtnFindDefaultProgram.UseVisualStyleBackColor = false;
            this.BtnFindDefaultProgram.Click += new System.EventHandler(this.BtnFindDefaultProgram_Click);
            // 
            // GroupBoxAddEntry
            // 
            this.GroupBoxAddEntry.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxAddEntry.Controls.Add(this.LblNoticeForAdding);
            this.GroupBoxAddEntry.Controls.Add(this.WtxtAddFileExtension);
            this.GroupBoxAddEntry.Controls.Add(this.BtnAddNewEntry);
            this.GroupBoxAddEntry.Controls.Add(this.WtxtAddDefaultProgram);
            this.GroupBoxAddEntry.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GroupBoxAddEntry.Location = new System.Drawing.Point(646, 47);
            this.GroupBoxAddEntry.Name = "GroupBoxAddEntry";
            this.GroupBoxAddEntry.Size = new System.Drawing.Size(622, 301);
            this.GroupBoxAddEntry.TabIndex = 0;
            this.GroupBoxAddEntry.TabStop = false;
            this.GroupBoxAddEntry.Text = "Add Entry";
            // 
            // LblNoticeForAdding
            // 
            this.LblNoticeForAdding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNoticeForAdding.AutoEllipsis = true;
            this.LblNoticeForAdding.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblNoticeForAdding.Location = new System.Drawing.Point(6, 216);
            this.LblNoticeForAdding.Name = "LblNoticeForAdding";
            this.LblNoticeForAdding.Size = new System.Drawing.Size(610, 82);
            this.LblNoticeForAdding.TabIndex = 0;
            this.LblNoticeForAdding.Text = "(Notice for adding)";
            this.LblNoticeForAdding.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GroupBoxDeleteEntry
            // 
            this.GroupBoxDeleteEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxDeleteEntry.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxDeleteEntry.Controls.Add(this.LblNoticeForDeleting);
            this.GroupBoxDeleteEntry.Controls.Add(this.BtnDeleteCurrentEntry);
            this.GroupBoxDeleteEntry.Controls.Add(this.BtnFindDefaultProgram);
            this.GroupBoxDeleteEntry.Controls.Add(this.WtxtFindFileExtension);
            this.GroupBoxDeleteEntry.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GroupBoxDeleteEntry.Location = new System.Drawing.Point(646, 354);
            this.GroupBoxDeleteEntry.Name = "GroupBoxDeleteEntry";
            this.GroupBoxDeleteEntry.Size = new System.Drawing.Size(622, 308);
            this.GroupBoxDeleteEntry.TabIndex = 0;
            this.GroupBoxDeleteEntry.TabStop = false;
            this.GroupBoxDeleteEntry.Text = "Delete Entry";
            // 
            // LblNoticeForDeleting
            // 
            this.LblNoticeForDeleting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNoticeForDeleting.AutoEllipsis = true;
            this.LblNoticeForDeleting.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblNoticeForDeleting.Location = new System.Drawing.Point(6, 232);
            this.LblNoticeForDeleting.Name = "LblNoticeForDeleting";
            this.LblNoticeForDeleting.Size = new System.Drawing.Size(610, 73);
            this.LblNoticeForDeleting.TabIndex = 0;
            this.LblNoticeForDeleting.Text = "(Notice for deleting)";
            this.LblNoticeForDeleting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataGridViewEntryList
            // 
            this.DataGridViewEntryList.AllowUserToAddRows = false;
            this.DataGridViewEntryList.AllowUserToDeleteRows = false;
            this.DataGridViewEntryList.AllowUserToResizeRows = false;
            this.DataGridViewEntryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewEntryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewEntryList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEntryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewEntryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewEntryList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewEntryList.Location = new System.Drawing.Point(12, 47);
            this.DataGridViewEntryList.Name = "DataGridViewEntryList";
            this.DataGridViewEntryList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewEntryList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewEntryList.RowHeadersVisible = false;
            this.DataGridViewEntryList.RowTemplate.Height = 27;
            this.DataGridViewEntryList.Size = new System.Drawing.Size(628, 632);
            this.DataGridViewEntryList.TabIndex = 0;
            this.DataGridViewEntryList.TabStop = false;
            // 
            // LblProgramNotice
            // 
            this.LblProgramNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProgramNotice.ForeColor = System.Drawing.Color.DarkOrange;
            this.LblProgramNotice.Location = new System.Drawing.Point(12, 682);
            this.LblProgramNotice.Name = "LblProgramNotice";
            this.LblProgramNotice.Size = new System.Drawing.Size(628, 29);
            this.LblProgramNotice.TabIndex = 0;
            this.LblProgramNotice.Text = "ATTENTION! Do not modify data in the file \"datafile.dat\"!";
            this.LblProgramNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WtxtAddFileExtension
            // 
            this.WtxtAddFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WtxtAddFileExtension.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.WtxtAddFileExtension.Location = new System.Drawing.Point(95, 57);
            this.WtxtAddFileExtension.Name = "WtxtAddFileExtension";
            this.WtxtAddFileExtension.Size = new System.Drawing.Size(432, 30);
            this.WtxtAddFileExtension.TabIndex = 0;
            this.WtxtAddFileExtension.TabStop = false;
            this.WtxtAddFileExtension.WatermarkText = "a file extension to be added";
            this.WtxtAddFileExtension.TextChanged += new System.EventHandler(this.WtxtAddFileExtension_TextChanged);
            // 
            // WtxtAddDefaultProgram
            // 
            this.WtxtAddDefaultProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WtxtAddDefaultProgram.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.WtxtAddDefaultProgram.Location = new System.Drawing.Point(95, 115);
            this.WtxtAddDefaultProgram.Name = "WtxtAddDefaultProgram";
            this.WtxtAddDefaultProgram.Size = new System.Drawing.Size(432, 30);
            this.WtxtAddDefaultProgram.TabIndex = 0;
            this.WtxtAddDefaultProgram.TabStop = false;
            this.WtxtAddDefaultProgram.WatermarkText = "a default program to be added";
            this.WtxtAddDefaultProgram.TextChanged += new System.EventHandler(this.WtxtAddDefaultProgram_TextChanged);
            // 
            // WtxtFindFileExtension
            // 
            this.WtxtFindFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WtxtFindFileExtension.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.WtxtFindFileExtension.Location = new System.Drawing.Point(95, 60);
            this.WtxtFindFileExtension.Name = "WtxtFindFileExtension";
            this.WtxtFindFileExtension.Size = new System.Drawing.Size(432, 30);
            this.WtxtFindFileExtension.TabIndex = 0;
            this.WtxtFindFileExtension.TabStop = false;
            this.WtxtFindFileExtension.WatermarkText = "a file extension to be found";
            this.WtxtFindFileExtension.TextChanged += new System.EventHandler(this.WtxtFindFileExtension_TextChanged);
            // 
            // FrmFileExtensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.LblProgramNotice);
            this.Controls.Add(this.DataGridViewEntryList);
            this.Controls.Add(this.BtnClearAll);
            this.Controls.Add(this.BtnListAll);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.GroupBoxAddEntry);
            this.Controls.Add(this.GroupBoxDeleteEntry);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFileExtensions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Extensions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFileExtensions_FormClosing);
            this.Load += new System.EventHandler(this.FrmFileExtensions_Load);
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.GroupBoxAddEntry.ResumeLayout(false);
            this.GroupBoxAddEntry.PerformLayout();
            this.GroupBoxDeleteEntry.ResumeLayout(false);
            this.GroupBoxDeleteEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEntryList)).EndInit();
            this.ResumeLayout(false);
        } // end method InitializeComponent
        #endregion Windows Form Designer Generated Code

        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Button BtnMinimise;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnListAll;
        private System.Windows.Forms.Button BtnClearAll;
        private System.Windows.Forms.Button BtnAddNewEntry;
        private System.Windows.Forms.Button BtnDeleteCurrentEntry;
        private System.Windows.Forms.Button BtnFindDefaultProgram;
        private WatermarkTextBox WtxtAddFileExtension;
        private System.Windows.Forms.GroupBox GroupBoxAddEntry;
        private WatermarkTextBox WtxtAddDefaultProgram;
        private System.Windows.Forms.GroupBox GroupBoxDeleteEntry;
        private WatermarkTextBox WtxtFindFileExtension;
        private System.Windows.Forms.Label LblNoticeForAdding;
        private System.Windows.Forms.Label LblNoticeForDeleting;
        private System.Windows.Forms.DataGridView DataGridViewEntryList;
        private System.Windows.Forms.Label LblProgramNotice;
    } // end partial class FrmFileExtensions
} // end namespace Exercise4_CSharp