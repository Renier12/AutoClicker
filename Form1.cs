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


        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        private const int WM_HOTKEY = 0x0312;
        private const int VK_F1 = 0x70; // F1 key
        private const int VK_F2 = 0x71; // F2 key

        private bool isClickHold = false;
        int milisecondsWait = 500;

        int count = 0;

        public AutoClicker()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, 1, 0, VK_F1); // Register F1
            RegisterHotKey(this.Handle, 2, 0, VK_F2); // Register F2
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    isClickHold = true;
                    DoMouseClick();
                    buttonStart.Text = "Clicking...";
                }
                else if (id == 2)
                {
                    isClickHold = false;
                    buttonStart.Text = "Idle";
                }
            }
            base.WndProc(ref m);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelIncrement();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            MessageBox.Show("Information");            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);
        }
    }
}
