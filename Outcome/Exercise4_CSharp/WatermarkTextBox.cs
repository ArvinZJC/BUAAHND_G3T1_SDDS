/*
 * @Description: csharp file that customises a text box to set a watermark to it
 * @Version: 3.0.0.1
 * @Author: Arvin Zhao
 * @Date: 2017-11-12 16:03:11
 * @Last Editors: Arvin Zhao
 * @LastEditTime: 2019-08-12 20:18:39
 */

#region Using Directives
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
#endregion Using Directives

namespace Exercise4_CSharp
{
    /// <summary>
    /// Extending from class TextBox, the partial class <see cref="WatermarkTextBox"/> sets a watermark to a text box.
    /// </summary>
    public partial class WatermarkTextBox : TextBox
    {
        public WatermarkTextBox()
        {
            InitializeComponent();
        } // end constructor WatermarkTextBox

        #region Members
        private const uint ECM_FIRST = 0x1500; // this constant is ID of the start of edit control messages
        /*
         * this constant is ID of the EM_SETCUEBANNER edit control message;
         * this message is a Windows Message to set the textual cue, or tip, that is displayed by the edit control to prompt the user for information;
         * the value of parameter wParam that this message specifies is 1 (if the cue banner should show even when the edit control has focus) or 0 (if the cue banner disappears when the user clicks in the control);
         * the value of parameter lParam that this message specifies is a pointer to a Unicode string that contains the text to display as the textual cue;
         * for detailed info, please refer to: https://docs.microsoft.com/en-us/windows/win32/controls/em-setcuebanner
         */
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;
        private string watermarkText; // the watermark set to a text box

        /// <summary>
        /// The text of a watermark.
        /// </summary>
        public string WatermarkText
        {
            get { return watermarkText; } // end get
            set
            {
                watermarkText = value;
                SetWatermark(watermarkText); // call the specified method to set a watermark to a text box
            } // end set
        }
        #endregion Members

        #region Private Methods
        /*
         * function SendMessage is an API function declared in "user32.dll";
         * this function sends the specified message to a window or windows;
         * this function calls the window procedure for the specified window and does not return until the window procedure has processed the message;
         * parameter hWnd represents a handle to the window whose window procedure will receive the message;
         * parameter Msg represents the Windows Message to be sent;
         * parameters wParam and lParam represents additional message-specific information;
         * for detailed info, please refer to: https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendmessage
         */
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // set a watermark to a text box
        private void SetWatermark(string watermarkText)
        {
            SendMessage(Handle, EM_SETCUEBANNER, 0, watermarkText);
        } // end method SetWatermark
        #endregion Private Methods
    } // end partial class WatermarkTextBox
} // end namespace Exercise4_CSharp