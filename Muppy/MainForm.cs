using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using IniParser;
using IniParser.Model;

namespace Muppy
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern Boolean GetLastInputInfo(ref tagLASTINPUTINFO lastInput);

        public struct tagLASTINPUTINFO
        {
            public uint cbSize;
            public Int32 dwTime;
        }

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_MINIMIZE = 6;
        private const int SW_MAXIMIZE = 3;
        private const int SW_RESTORE = 9;

        int _state = -1;
        int _idleTime = 0;
        List<Process> current;
        public MainForm()
        {
            InitializeComponent();
            current = new List<Process>();
        }

        private void timerLastInput_Tick(object sender, EventArgs e)
        {
            tagLASTINPUTINFO LastInput = new tagLASTINPUTINFO();
            Int32 IdleTime;
            LastInput.cbSize = (uint)Marshal.SizeOf(LastInput);
            LastInput.dwTime = 0;

            if (GetLastInputInfo(ref LastInput))
            {

                IdleTime = System.Environment.TickCount - LastInput.dwTime;
                _idleTime = IdleTime;
            }
        }

        private void timerIdleDetect_Tick(object sender, EventArgs e)
        {
            // -1 = not mining; 0 = not idle, mining; 1 = idle, mining; 2 = conditional, mining
            // If the computer becomes idle and idle mining is enabled
            if ((_state == 0 || _state == -1) && checkBoxIdle.Checked && _idleTime > numericUpDownIdleDelay.Value * 1000)
            {
                if (_state == 0)
                    log("[not-idle]Mining stopped.");
                log("[idle]Mining started...");
                _state = 1;
                switchState();
            }
            // If the computer becomes not idle, stop mining
            if (_state == 1 && _idleTime < 2000)
            {
                log("[idle]Mining stopped.");
                _state = -1;
                switchState();
            }
            // If the computer is not idle and non-idle mining is enabled
            if (_state == -1 && checkBoxNotIdle.Checked)
            {
                log("[not-idle]Mining started...");
                _state = 0;
                switchState();
            }
            // If the computer is not idle and conditional mining is enabled
            if ((_state == 0 || _state == -1) && checkBoxConditional.Checked)
            {
                List<String> listStrLineElements = textBoxConditionalPrograms.Text.Split(',').ToList();

                Process[] processlist = Process.GetProcesses();
                // Check if any of running windows/processes match
                foreach (Process process in processlist)
                {
                    if (!String.IsNullOrEmpty(process.MainWindowTitle))
                    {
                        foreach (String s in listStrLineElements)
                        {
                            if (process.ProcessName.ToLower() == s.ToLower() || process.MainWindowTitle.ToLower() == s.ToLower())
                            {
                                _state = 2;
                                goto SearchFinished;
                            }

                        }
                    }
                }
                return;
                SearchFinished:;
                log("[conditional]Found listed program, switching...");
                switchState();
            }
            // If the computer is in conditional mining, check if program is still there
            if ((_state == 2) && checkBoxConditional.Checked)
            {
                List<String> listStrLineElements = textBoxConditionalPrograms.Text.Split(',').ToList();

                if(IsAnyProgramRunning(listStrLineElements))
                {
                    _state = 2;
                    return;
                }
                else
                {
                    log("[conditional]Program no longer found, switching.");
                    _state = -1;
                    switchState();
                }

                return;
            }
        }

        private bool IsAnyProgramRunning(List<String> nameList)
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    foreach (String s in nameList)
                    {
                        if (process.ProcessName.ToLower() == s.ToLower() || process.MainWindowTitle.ToLower() == s.ToLower())
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private void switchState()
        {
            foreach (Process p in current)
            {
                try
                {
                    p.CloseMainWindow();
                }
                catch (InvalidOperationException)
                {
                }
            }
            current.Clear();

            if (_state == 0 && checkBoxNotIdle.Checked)
            {
                var textLines = textBoxProcessNotIdle.Text.Split('\n');
                foreach (var line in textLines)
                {
                    if (line != "")
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "/c " + line;

                        Process newProcess = Process.Start(startInfo);

                        current.Add(newProcess);
                    }
                }

            }
            else if (_state == 1 && checkBoxIdle.Checked)
            {
                var textLines = textBoxProcessIdle.Text.Split('\n');
                foreach (var line in textLines)
                {
                    if (line != "")
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "/c " + line;

                        Process newProcess = Process.Start(startInfo);

                        current.Add(newProcess);
                    }
                }

            }
            else if (_state == 2 && checkBoxConditional.Checked)
            {
                var textLines = textBoxProcessConditional.Text.Split('\n');
                foreach (var line in textLines)
                {
                    if (line != "")
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "/c " + line;

                        Process newProcess = Process.Start(startInfo);

                        current.Add(newProcess);
                    }
                }

            }
        }

        private void log(String text)
        {
            listBoxLog.Items.Add($"{DateTime.Now.ToString("HH:mm:ss")}: {text}");
            listBoxLog.TopIndex = listBoxLog.Items.Count - 1;
        }

        private void saveSettings()
        {
            var parser = new FileIniDataParser();
            IniData data = new IniData();
            data["Checkbox"]["Idle"] = checkBoxIdle.Checked.ToString();
            data["Checkbox"]["NotIdle"] = checkBoxNotIdle.Checked.ToString();
            data["Checkbox"]["Conditional"] = checkBoxConditional.Checked.ToString();
            data["Checkbox"]["Restart"] = checkBoxRestart.Checked.ToString();

            data["Textbox"]["Idle"] = textBoxProcessIdle.Text.Replace(Environment.NewLine, "\\n");
            data["Textbox"]["NotIdle"] = textBoxProcessNotIdle.Text.Replace(Environment.NewLine, "\\n");
            data["Textbox"]["Conditional"] = textBoxProcessConditional.Text.Replace(Environment.NewLine, "\\n");

            data["Misc"]["IdleDelay"] = numericUpDownIdleDelay.Value.ToString();
            data["Misc"]["RestartDelay"] = numericUpDownRestartDelay.Value.ToString();
            data["Misc"]["ConditionalPrograms"] = textBoxConditionalPrograms.Text;

            parser.WriteFile("config.ini", data);
        }

        private void loadSettings()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("config.ini");

            checkBoxIdle.Checked = bool.Parse(data["Checkbox"]["Idle"]);
            checkBoxNotIdle.Checked = bool.Parse(data["Checkbox"]["NotIdle"]);
            checkBoxConditional.Checked = bool.Parse(data["Checkbox"]["Conditional"]);
            checkBoxRestart.Checked = bool.Parse(data["Checkbox"]["Restart"]);

            textBoxProcessIdle.Text = data["Textbox"]["Idle"].Replace("\\n", Environment.NewLine);
            textBoxProcessNotIdle.Text = data["Textbox"]["NotIdle"].Replace("\\n", Environment.NewLine);
            textBoxProcessConditional.Text = data["Textbox"]["Conditional"].Replace("\\n", Environment.NewLine);

            numericUpDownIdleDelay.Value = int.Parse(data["Misc"]["IdleDelay"]);
            numericUpDownRestartDelay.Value = int.Parse(data["Misc"]["RestartDelay"]);
            textBoxConditionalPrograms.Text = data["Misc"]["ConditionalPrograms"];
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();

            foreach (Process p in current)
            {
                try
                {
                    p.CloseMainWindow();
                }
                catch (InvalidOperationException)
                {
                }
            }
            current.Clear();

            System.Windows.Forms.Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadSettings();
            if (checkBoxRestart.Checked)
            {
                timerRestart.Interval = (int)numericUpDownRestartDelay.Value * 60 * 1000;
                timerRestart.Enabled = true;
            }
        }

        private void checkBoxIdle_CheckedChanged(object sender, EventArgs e)
        {
            switchState();
        }

        private void timerRestart_Tick(object sender, EventArgs e)
        {
            switchState();
        }

        private void checkBoxRestart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRestart.Checked)
            {
                timerRestart.Interval = (int)numericUpDownRestartDelay.Value * 60 * 1000;
                timerRestart.Enabled = true;
            }
            else
            {
                timerRestart.Enabled = false;
            }
        }

        private void numericUpDownRestartDelay_ValueChanged(object sender, EventArgs e)
        {
            timerRestart.Interval = (int)numericUpDownRestartDelay.Value * 60 * 1000;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;

                foreach (Process p in current)
                {
                        ShowWindow(p.MainWindowHandle, SW_MINIMIZE);
                }

                notifyIcon.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;

            foreach (Process p in current)
            {
                ShowWindow(p.MainWindowHandle, SW_RESTORE);
            }
        }
    }
}

