// Created By Tamoza
// www.tamoza.net

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        [Flags]
        enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x0000000,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 100, AnimateWindowFlags.AW_VER_POSITIVE | AnimateWindowFlags.AW_SLIDE);
        }
    }
}
