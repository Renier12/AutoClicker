namespace AutoClicker
{
    partial class AutoClicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            menuStrip1 = new MenuStrip();
            informationToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            labelOutput1 = new Label();
            buttonStart = new Button();
            textboxEnableClick = new CheckBox();
            labelDelay = new Label();
            textBoxDelay = new TextBox();
            textBoxRandMin = new TextBox();
            textBoxRandMax = new TextBox();
            labelRandMin = new Label();
            labelRandMax = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { informationToolStripMenuItem, eXITToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(224, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(82, 20);
            informationToolStripMenuItem.Text = "Information";
            informationToolStripMenuItem.Click += informationToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.RightToLeft = RightToLeft.No;
            eXITToolStripMenuItem.Size = new Size(38, 20);
            eXITToolStripMenuItem.Text = "Exit";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // labelOutput1
            // 
            labelOutput1.AutoSize = true;
            labelOutput1.Location = new Point(81, 177);
            labelOutput1.Name = "labelOutput1";
            labelOutput1.Size = new Size(51, 15);
            labelOutput1.TabIndex = 2;
            labelOutput1.Text = "Output1";
            labelOutput1.Click += labelOutput1_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 111);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(198, 63);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Status";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textboxEnableClick
            // 
            textboxEnableClick.AutoSize = true;
            textboxEnableClick.Location = new Point(12, 63);
            textboxEnableClick.Name = "textboxEnableClick";
            textboxEnableClick.Size = new Size(154, 19);
            textboxEnableClick.TabIndex = 1;
            textboxEnableClick.Text = "Use Random Times (ms)";
            textboxEnableClick.UseVisualStyleBackColor = true;
            textboxEnableClick.CheckedChanged += textboxEnableClick_CheckedChanged;
            // 
            // labelDelay
            // 
            labelDelay.AutoSize = true;
            labelDelay.Location = new Point(12, 37);
            labelDelay.Name = "labelDelay";
            labelDelay.Size = new Size(63, 15);
            labelDelay.TabIndex = 4;
            labelDelay.Text = "Delay (ms)";
            // 
            // textBoxDelay
            // 
            textBoxDelay.Location = new Point(81, 34);
            textBoxDelay.Name = "textBoxDelay";
            textBoxDelay.Size = new Size(100, 23);
            textBoxDelay.TabIndex = 5;
            textBoxDelay.Text = "100";
            // 
            // textBoxRandMin
            // 
            textBoxRandMin.Enabled = false;
            textBoxRandMin.Location = new Point(46, 82);
            textBoxRandMin.Name = "textBoxRandMin";
            textBoxRandMin.Size = new Size(61, 23);
            textBoxRandMin.TabIndex = 7;
            textBoxRandMin.TextChanged += textBox2_TextChanged;
            // 
            // textBoxRandMax
            // 
            textBoxRandMax.Enabled = false;
            textBoxRandMax.Location = new Point(149, 82);
            textBoxRandMax.Name = "textBoxRandMax";
            textBoxRandMax.Size = new Size(61, 23);
            textBoxRandMax.TabIndex = 8;
            textBoxRandMax.TextChanged += textBoxRandMax_TextChanged;
            // 
            // labelRandMin
            // 
            labelRandMin.AutoSize = true;
            labelRandMin.Enabled = false;
            labelRandMin.Location = new Point(12, 85);
            labelRandMin.Name = "labelRandMin";
            labelRandMin.Size = new Size(28, 15);
            labelRandMin.TabIndex = 9;
            labelRandMin.Text = "Min";
            labelRandMin.Click += labelRandMin_Click;
            // 
            // labelRandMax
            // 
            labelRandMax.AutoSize = true;
            labelRandMax.Enabled = false;
            labelRandMax.Location = new Point(113, 85);
            labelRandMax.Name = "labelRandMax";
            labelRandMax.Size = new Size(30, 15);
            labelRandMax.TabIndex = 10;
            labelRandMax.Text = "Max";
            // 
            // AutoClicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 202);
            Controls.Add(labelRandMax);
            Controls.Add(labelRandMin);
            Controls.Add(textBoxRandMax);
            Controls.Add(textBoxRandMin);
            Controls.Add(textBoxDelay);
            Controls.Add(labelDelay);
            Controls.Add(buttonStart);
            Controls.Add(labelOutput1);
            Controls.Add(textboxEnableClick);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "AutoClicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoClicker";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private Label labelOutput1;
        private Button buttonStart;
        private ToolStripMenuItem informationToolStripMenuItem;
        private CheckBox textboxEnableClick;
        private Label labelDelay;
        private TextBox textBoxDelay;
        private TextBox textBoxRandMin;
        private TextBox textBoxRandMax;
        private Label labelRandMin;
        private Label labelRandMax;
    }
}
