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
        int milisecondsWait = 100;
        int randMin = 20;
        int randMax = 100;

        int count = 0;

        public AutoClicker()
        {
            InitializeComponent();
            labelOutput1.Text = string.Empty;
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
                    setMilisecondDelay(); //this is done afer isClickHold is set to ensure delay is valid
                    if (textboxEnableClick.Checked)
                    {
                        setRandValues();
                    }
                    DoMouseClick();
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

        private void setMilisecondDelay()
        {
            if (!int.TryParse(textBoxDelay.Text, out milisecondsWait))
            {
                MessageBox.Show("Delay must be an integer");
                textBoxDelay.Text = "100";
                isClickHold = false;
            }
        }

        private void setRandValues() //Check if randValues are valid
        {
            if (!int.TryParse(textBoxRandMin.Text, out randMin))
            {
                MessageBox.Show("Minimum value must be an interger!");
                isClickHold = false;
                textBoxRandMin.Text = "20";
            }

            if (!int.TryParse(textBoxRandMax.Text, out randMax))
            {
                MessageBox.Show("Maximum value must be an interger!");
                isClickHold = false;
                textBoxRandMax.Text = milisecondsWait.ToString();
            }
        }

        private void DoMouseClick()
        {
            buttonStart.Text = "Clicking...";
            if (textboxEnableClick.Checked)
            {
                new Thread(() =>
                {
                    Random rand = new Random();
                    while (isClickHold)
                    {
                        milisecondsWait = rand.Next(randMin, randMax);
                        Thread.CurrentThread.IsBackground = true;
                        uint X = (uint)Cursor.Position.X;
                        uint Y = (uint)Cursor.Position.Y;
                        mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, UIntPtr.Zero);
                        mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, UIntPtr.Zero);
                        Thread.Sleep(milisecondsWait);
                    }
                }).Start();
            }
            else
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
        }

        public void labelIncrement()
        {
            count++;
            labelOutput1.Text = "Clicks: " + count.ToString();
        }

        private void textboxEnableClick_CheckedChanged(object sender, EventArgs e)
        {
            if (textboxEnableClick.Checked)
            {
                labelRandMax.Enabled = true;
                textBoxRandMax.Enabled = true;
                textBoxRandMax.Text = "100";
                labelRandMin.Enabled = true;
                textBoxRandMin.Enabled = true;
                textBoxRandMin.Text = "20";
                labelDelay.Enabled = false;
                textBoxDelay.Enabled = false;
            }
            else
            {
                labelRandMax.Enabled = false;
                textBoxRandMax.Enabled = false;
                labelRandMin.Enabled = false;
                textBoxRandMin.Enabled = false;
                labelDelay.Enabled = true;
                textBoxDelay.Enabled = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelIncrement();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press 'F1' to start" + '\n' +
                "Press 'F2' to stop");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRandMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRandMin_Click(object sender, EventArgs e)
        {

        }

        private void labelOutput1_Click(object sender, EventArgs e)
        {

        }
    }
}
