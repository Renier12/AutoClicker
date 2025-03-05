using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoClicker

{
    public partial class AutoClicker : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        private bool isClickHold = false;
        int milisecondsWait = 500;

        int count = 0;

        public AutoClicker()
        {
            InitializeComponent();
            this.MouseClick += mouseClick;

            this.KeyPreview = true;
            this.KeyDown += Cancel_KeyDown;
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {

             isClickHold = true;
             if (Control.ModifierKeys.ToString() == "Alt")
             {
                DoMouseClick();
                buttonStart.Text = "Clicking...";
             }
        }

        private void DoMouseClick()
        {
            new Thread(() =>
            {
                while (isClickHold)
                {
                    Thread.CurrentThread.IsBackground = true;
                    uint X = (uint)Cursor.Position.X;
                    uint Y = (uint)Cursor.Position.Y;
                    mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, UIntPtr.Zero);
                    Thread.Sleep(milisecondsWait);
                }
            }).Start();
        }

        public void labelIncrement()
        {
            count++;
            labelOutput1.Text = count.ToString();
        }

        private void textboxEnableClick_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Shift)
            {
                isClickHold = false;
                buttonStart.Text = "Idle";
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelIncrement();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information");
        }
    }
}
