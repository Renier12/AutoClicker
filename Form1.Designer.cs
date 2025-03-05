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
            menuStrip1 = new MenuStrip();
            informationToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            textboxEnableClick = new CheckBox();
            labelOutput1 = new Label();
            buttonStart = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { informationToolStripMenuItem, eXITToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
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
            eXITToolStripMenuItem.Size = new Size(38, 20);
            eXITToolStripMenuItem.Text = "Exit";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // textboxEnableClick
            // 
            textboxEnableClick.AutoSize = true;
            textboxEnableClick.Location = new Point(12, 81);
            textboxEnableClick.Name = "textboxEnableClick";
            textboxEnableClick.Size = new Size(57, 19);
            textboxEnableClick.TabIndex = 1;
            textboxEnableClick.Text = "Click?";
            textboxEnableClick.UseVisualStyleBackColor = true;
            textboxEnableClick.CheckedChanged += textboxEnableClick_CheckedChanged;
            // 
            // labelOutput1
            // 
            labelOutput1.AutoSize = true;
            labelOutput1.Location = new Point(125, 82);
            labelOutput1.Name = "labelOutput1";
            labelOutput1.Size = new Size(51, 15);
            labelOutput1.TabIndex = 2;
            labelOutput1.Text = "Output1";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 121);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(106, 63);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // AutoClicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStart);
            Controls.Add(labelOutput1);
            Controls.Add(textboxEnableClick);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AutoClicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Clicker";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private CheckBox textboxEnableClick;
        private Label labelOutput1;
        private Button buttonStart;
        private ToolStripMenuItem informationToolStripMenuItem;
    }
}
