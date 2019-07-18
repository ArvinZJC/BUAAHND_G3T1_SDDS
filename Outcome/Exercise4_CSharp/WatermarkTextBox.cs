/*
 * @Description: csharp file that customises a user control which allows the user to create a text box with a watermark inside
 * @Version: 3.0.0.0
 * @Author: Arvin Zhao
 * @Date: 2017-11-12 16:03:11
 * @Last Editors: Arvin Zhao
 * @LastEditTime: 2018-12-07 01:59:17
 */

#region Using Directives
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
#endregion Using Directives

namespace Exercise4_CSharp
{
    /// <summary>
    /// Extending from class TextBox, the partial class <see cref="WatermarkTextBox"/> enables a watermark inside a text box.
    /// </summary>
    public partial class WatermarkTextBox : TextBox
    {
        public WatermarkTextBox()
        {
            InitializeComponent();
        } // end constructor WatermarkTextBox

        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private string watermarkText;
        public string WatermarkText
        {
            get { return watermarkText; } // end get
            set
            {
                watermarkText = value;
                SetWatermark(watermarkText); // call the specified method to set a watermark inside a text box
            } // end set
        } // end string WatermarkText

        /// <summary>
        /// Set a watermark inside a text box.
        /// </summary>
        /// <param name="watermarkText">The watermark displayed inside the text box.</param>
        private void SetWatermark(string watermarkText)
        {
            SendMessage(this.Handle, EM_SETCUEBANNER, 0, watermarkText);
        } // end method SetWatermark
    } // end partial class WatermarkTextBox
} // end namespace Exercise4_CSharp