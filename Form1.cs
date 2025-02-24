using System;
using System.Runtime.InteropServices;

//Imports
[DllImport("user32.dll")]
static extern void mouse_event(unit dwFlags, unit dx, )


namespace AutoClicker

{
    public partial class AutoClicker : Form
    {
        public AutoClicker()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
