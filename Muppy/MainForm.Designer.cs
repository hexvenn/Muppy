namespace Muppy
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerLastInput = new System.Windows.Forms.Timer(this.components);
            this.textBoxProcessIdle = new System.Windows.Forms.TextBox();
            this.textBoxProcessNotIdle = new System.Windows.Forms.TextBox();
            this.textBoxProcessConditional = new System.Windows.Forms.TextBox();
            this.groupBoxIdle = new System.Windows.Forms.GroupBox();
            this.labelIdleTime = new System.Windows.Forms.Label();
            this.numericUpDownIdleDelay = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIdle = new System.Windows.Forms.CheckBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBoxNotIdle = new System.Windows.Forms.GroupBox();
            this.checkBoxNotIdle = new System.Windows.Forms.CheckBox();
            this.groupBoxConditional = new System.Windows.Forms.GroupBox();
            this.labelConditionalPrograms = new System.Windows.Forms.Label();
            this.checkBoxConditional = new System.Windows.Forms.CheckBox();
            this.textBoxConditionalPrograms = new System.Windows.Forms.TextBox();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.timerIdleDetect = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownRestartDelay = new System.Windows.Forms.NumericUpDown();
            this.timerRestart = new System.Windows.Forms.Timer(this.components);
            this.checkBoxRestart = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxIdle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdleDelay)).BeginInit();
            this.groupBoxNotIdle.SuspendLayout();
            this.groupBoxConditional.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLastInput
            // 
            this.timerLastInput.Enabled = true;
            this.timerLastInput.Tick += new System.EventHandler(this.timerLastInput_Tick);
            // 
            // textBoxProcessIdle
            // 
            this.textBoxProcessIdle.Location = new System.Drawing.Point(6, 42);
            this.textBoxProcessIdle.Multiline = true;
            this.textBoxProcessIdle.Name = "textBoxProcessIdle";
            this.textBoxProcessIdle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxProcessIdle.Size = new System.Drawing.Size(754, 52);
            this.textBoxProcessIdle.TabIndex = 1;
            this.textBoxProcessIdle.WordWrap = false;
            // 
            // textBoxProcessNotIdle
            // 
            this.textBoxProcessNotIdle.Location = new System.Drawing.Point(6, 42);
            this.textBoxProcessNotIdle.Multiline = true;
            this.textBoxProcessNotIdle.Name = "textBoxProcessNotIdle";
            this.textBoxProcessNotIdle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxProcessNotIdle.Size = new System.Drawing.Size(754, 52);
            this.textBoxProcessNotIdle.TabIndex = 2;
            this.textBoxProcessNotIdle.WordWrap = false;
            // 
            // textBoxProcessConditional
            // 
            this.textBoxProcessConditional.Location = new System.Drawing.Point(6, 45);
            this.textBoxProcessConditional.Multiline = true;
            this.textBoxProcessConditional.Name = "textBoxProcessConditional";
            this.textBoxProcessConditional.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxProcessConditional.Size = new System.Drawing.Size(748, 49);
            this.textBoxProcessConditional.TabIndex = 3;
            this.textBoxProcessConditional.WordWrap = false;
            // 
            // groupBoxIdle
            // 
            this.groupBoxIdle.Controls.Add(this.labelIdleTime);
            this.groupBoxIdle.Controls.Add(this.numericUpDownIdleDelay);
            this.groupBoxIdle.Controls.Add(this.checkBoxIdle);
            this.groupBoxIdle.Controls.Add(this.textBoxProcessIdle);
            this.groupBoxIdle.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIdle.Name = "groupBoxIdle";
            this.groupBoxIdle.Size = new System.Drawing.Size(760, 100);
            this.groupBoxIdle.TabIndex = 4;
            this.groupBoxIdle.TabStop = false;
            this.groupBoxIdle.Text = "Computer is idle";
            // 
            // labelIdleTime
            // 
            this.labelIdleTime.AutoSize = true;
            this.labelIdleTime.Location = new System.Drawing.Point(572, 16);
            this.labelIdleTime.Name = "labelIdleTime";
            this.labelIdleTime.Size = new System.Drawing.Size(56, 13);
            this.labelIdleTime.TabIndex = 4;
            this.labelIdleTime.Text = "Idle [sec]: ";
            // 
            // numericUpDownIdleDelay
            // 
            this.numericUpDownIdleDelay.Location = new System.Drawing.Point(634, 14);
            this.numericUpDownIdleDelay.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownIdleDelay.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownIdleDelay.Name = "numericUpDownIdleDelay";
            this.numericUpDownIdleDelay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIdleDelay.TabIndex = 3;
            this.numericUpDownIdleDelay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // checkBoxIdle
            // 
            this.checkBoxIdle.AutoSize = true;
            this.checkBoxIdle.Checked = true;
            this.checkBoxIdle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIdle.Location = new System.Drawing.Point(6, 19);
            this.checkBoxIdle.Name = "checkBoxIdle";
            this.checkBoxIdle.Size = new System.Drawing.Size(65, 17);
            this.checkBoxIdle.TabIndex = 2;
            this.checkBoxIdle.Text = "Enabled";
            this.checkBoxIdle.UseVisualStyleBackColor = true;
            this.checkBoxIdle.CheckedChanged += new System.EventHandler(this.checkBoxIdle_CheckedChanged);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(6, 19);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(748, 69);
            this.listBoxLog.TabIndex = 5;
            // 
            // groupBoxNotIdle
            // 
            this.groupBoxNotIdle.Controls.Add(this.checkBoxNotIdle);
            this.groupBoxNotIdle.Controls.Add(this.textBoxProcessNotIdle);
            this.groupBoxNotIdle.Location = new System.Drawing.Point(12, 118);
            this.groupBoxNotIdle.Name = "groupBoxNotIdle";
            this.groupBoxNotIdle.Size = new System.Drawing.Size(760, 100);
            this.groupBoxNotIdle.TabIndex = 6;
            this.groupBoxNotIdle.TabStop = false;
            this.groupBoxNotIdle.Text = "Computer is not idle";
            // 
            // checkBoxNotIdle
            // 
            this.checkBoxNotIdle.AutoSize = true;
            this.checkBoxNotIdle.Location = new System.Drawing.Point(6, 19);
            this.checkBoxNotIdle.Name = "checkBoxNotIdle";
            this.checkBoxNotIdle.Size = new System.Drawing.Size(65, 17);
            this.checkBoxNotIdle.TabIndex = 3;
            this.checkBoxNotIdle.Text = "Enabled";
            this.checkBoxNotIdle.UseVisualStyleBackColor = true;
            this.checkBoxNotIdle.CheckedChanged += new System.EventHandler(this.checkBoxIdle_CheckedChanged);
            // 
            // groupBoxConditional
            // 
            this.groupBoxConditional.Controls.Add(this.labelConditionalPrograms);
            this.groupBoxConditional.Controls.Add(this.checkBoxConditional);
            this.groupBoxConditional.Controls.Add(this.textBoxConditionalPrograms);
            this.groupBoxConditional.Controls.Add(this.textBoxProcessConditional);
            this.groupBoxConditional.Location = new System.Drawing.Point(12, 224);
            this.groupBoxConditional.Name = "groupBoxConditional";
            this.groupBoxConditional.Size = new System.Drawing.Size(760, 100);
            this.groupBoxConditional.TabIndex = 7;
            this.groupBoxConditional.TabStop = false;
            this.groupBoxConditional.Text = "Running certain programs";
            // 
            // labelConditionalPrograms
            // 
            this.labelConditionalPrograms.AutoSize = true;
            this.labelConditionalPrograms.Location = new System.Drawing.Point(122, 22);
            this.labelConditionalPrograms.Name = "labelConditionalPrograms";
            this.labelConditionalPrograms.Size = new System.Drawing.Size(54, 13);
            this.labelConditionalPrograms.TabIndex = 6;
            this.labelConditionalPrograms.Text = "Programs:";
            // 
            // checkBoxConditional
            // 
            this.checkBoxConditional.AutoSize = true;
            this.checkBoxConditional.Location = new System.Drawing.Point(6, 22);
            this.checkBoxConditional.Name = "checkBoxConditional";
            this.checkBoxConditional.Size = new System.Drawing.Size(65, 17);
            this.checkBoxConditional.TabIndex = 5;
            this.checkBoxConditional.Text = "Enabled";
            this.checkBoxConditional.UseVisualStyleBackColor = true;
            this.checkBoxConditional.CheckedChanged += new System.EventHandler(this.checkBoxIdle_CheckedChanged);
            // 
            // textBoxConditionalPrograms
            // 
            this.textBoxConditionalPrograms.Location = new System.Drawing.Point(182, 20);
            this.textBoxConditionalPrograms.Name = "textBoxConditionalPrograms";
            this.textBoxConditionalPrograms.Size = new System.Drawing.Size(572, 20);
            this.textBoxConditionalPrograms.TabIndex = 4;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.listBoxLog);
            this.groupBoxLog.Location = new System.Drawing.Point(12, 330);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(760, 100);
            this.groupBoxLog.TabIndex = 8;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Log";
            // 
            // timerIdleDetect
            // 
            this.timerIdleDetect.Enabled = true;
            this.timerIdleDetect.Interval = 1000;
            this.timerIdleDetect.Tick += new System.EventHandler(this.timerIdleDetect_Tick);
            // 
            // numericUpDownRestartDelay
            // 
            this.numericUpDownRestartDelay.Location = new System.Drawing.Point(652, 436);
            this.numericUpDownRestartDelay.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownRestartDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRestartDelay.Name = "numericUpDownRestartDelay";
            this.numericUpDownRestartDelay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRestartDelay.TabIndex = 9;
            this.numericUpDownRestartDelay.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownRestartDelay.ValueChanged += new System.EventHandler(this.numericUpDownRestartDelay_ValueChanged);
            // 
            // timerRestart
            // 
            this.timerRestart.Tick += new System.EventHandler(this.timerRestart_Tick);
            // 
            // checkBoxRestart
            // 
            this.checkBoxRestart.AutoSize = true;
            this.checkBoxRestart.Location = new System.Drawing.Point(498, 437);
            this.checkBoxRestart.Name = "checkBoxRestart";
            this.checkBoxRestart.Size = new System.Drawing.Size(148, 17);
            this.checkBoxRestart.TabIndex = 11;
            this.checkBoxRestart.Text = "Restart tasks every [min]: ";
            this.checkBoxRestart.UseVisualStyleBackColor = true;
            this.checkBoxRestart.CheckedChanged += new System.EventHandler(this.checkBoxRestart_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Minimized to tray";
            this.notifyIcon.BalloonTipTitle = "Mup";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Mup";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.checkBoxRestart);
            this.Controls.Add(this.numericUpDownRestartDelay);
            this.Controls.Add(this.groupBoxLog);
            this.Controls.Add(this.groupBoxConditional);
            this.Controls.Add(this.groupBoxNotIdle);
            this.Controls.Add(this.groupBoxIdle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Muppy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBoxIdle.ResumeLayout(false);
            this.groupBoxIdle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdleDelay)).EndInit();
            this.groupBoxNotIdle.ResumeLayout(false);
            this.groupBoxNotIdle.PerformLayout();
            this.groupBoxConditional.ResumeLayout(false);
            this.groupBoxConditional.PerformLayout();
            this.groupBoxLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerLastInput;
        private System.Windows.Forms.TextBox textBoxProcessIdle;
        private System.Windows.Forms.TextBox textBoxProcessNotIdle;
        private System.Windows.Forms.TextBox textBoxProcessConditional;
        private System.Windows.Forms.GroupBox groupBoxIdle;
        private System.Windows.Forms.Label labelIdleTime;
        private System.Windows.Forms.NumericUpDown numericUpDownIdleDelay;
        private System.Windows.Forms.CheckBox checkBoxIdle;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.GroupBox groupBoxNotIdle;
        private System.Windows.Forms.CheckBox checkBoxNotIdle;
        private System.Windows.Forms.GroupBox groupBoxConditional;
        private System.Windows.Forms.Label labelConditionalPrograms;
        private System.Windows.Forms.CheckBox checkBoxConditional;
        private System.Windows.Forms.TextBox textBoxConditionalPrograms;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.Timer timerIdleDetect;
        private System.Windows.Forms.NumericUpDown numericUpDownRestartDelay;
        private System.Windows.Forms.Timer timerRestart;
        private System.Windows.Forms.CheckBox checkBoxRestart;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

