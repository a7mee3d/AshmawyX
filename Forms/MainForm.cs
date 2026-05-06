using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AshmawyX
{
    public partial class MainForm : Form
    {
        private IntPtr mainHandle = IntPtr.Zero;
        private IntPtr secondHandle = IntPtr.Zero;

        private Engine engine;

        // Settings stored here after coming from SettingsForm
        private AppSettings settings = new AppSettings();

        public MainForm()
        {
            InitializeComponent();
            engine = new Engine();

            ApplyGlow(btnStart);
            ApplyGlow(btnPause);
            ApplyGlow(btnStop);
            ApplyGlow(btnSettings);
            ApplyGlow(btnAbout);
            ApplyGlow(btnSetMain);
            ApplyGlow(btnSetSecond);

            WireEvents();
            LoadSettings();
            UpdateStatus("Ready");
        }

        // ---------------------------------------------------------
        // EVENT WIRING
        // ---------------------------------------------------------
        private void WireEvents()
        {
            btnSetMain.Click += BtnSetMain_Click;
            btnSetSecond.Click += BtnSetSecond_Click;

            btnStart.Click += BtnStart_Click;
            btnPause.Click += BtnPause_Click;
            btnStop.Click += BtnStop_Click;

            btnAbout.Click += (s, e) => new AboutForm().ShowDialog();

            btnSettings.Click += BtnSettings_Click;
        }

        // ---------------------------------------------------------
        // SETTINGS WINDOW
        // ---------------------------------------------------------
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(settings);
            sf.ShowDialog();

            // Reload settings after closing
            settings = sf.ReturnedSettings;
            SaveSettings();
            UpdateStatus("Settings updated");
        }

        // ---------------------------------------------------------
        // CLIENT SELECTION
        // ---------------------------------------------------------
        private void BtnSetMain_Click(object sender, EventArgs e)
        {
            if (cmbMain.SelectedItem == null)
            {
                UpdateStatus("Select a main client first");
                return;
            }

            mainHandle = FindWindowByTitle(cmbMain.SelectedItem.ToString());
            lblMainSet.Visible = true;
            UpdateStatus("Main client set");
        }

        private void BtnSetSecond_Click(object sender, EventArgs e)
        {
            if (cmbSecond.SelectedItem == null)
            {
                UpdateStatus("Select a second client first");
                return;
            }

            secondHandle = FindWindowByTitle(cmbSecond.SelectedItem.ToString());
            lblSecondSet.Visible = true;
            UpdateStatus("Second client set");
        }

        private IntPtr FindWindowByTitle(string title)
        {
            foreach (var proc in Process.GetProcesses())
            {
                if (proc.MainWindowHandle != IntPtr.Zero &&
                    proc.MainWindowTitle.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return proc.MainWindowHandle;
                }
            }
            return IntPtr.Zero;
        }

        // ---------------------------------------------------------
        // ENGINE CONTROL
        // ---------------------------------------------------------
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (mainHandle == IntPtr.Zero || secondHandle == IntPtr.Zero)
            {
                UpdateStatus("Set both clients first");
                return;
            }

            engine.MainHandle = mainHandle;
            engine.SecondHandle = secondHandle;

            engine.EnableDelay = settings.DelayEnabled;
            engine.MinDelay = settings.MinDelay;
            engine.MaxDelay = settings.MaxDelay;

            engine.ChatBlock = true; // always ON
            engine.BlockedKeys = settings.BlockedKeys.ToList();

            engine.Start();
            UpdateStatus("Running");
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            engine.Pause();
            UpdateStatus("Paused");
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            engine.Stop();
            UpdateStatus("Stopped");
        }

        // ---------------------------------------------------------
        // STATUS
        // ---------------------------------------------------------
        private void UpdateStatus(string text)
        {
            lblStatus.Text = text;
        }

        // ---------------------------------------------------------
        // SETTINGS SAVE / LOAD
        // ---------------------------------------------------------
        private void LoadSettings()
        {
            settings = SettingsManager.Load();
        }

        private void SaveSettings()
        {
            SettingsManager.Save(settings);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveSettings();
            base.OnFormClosing(e);
        }

        // ---------------------------------------------------------
        // SOFT GLOW (BEST FOR EYES)
        // ---------------------------------------------------------
        private void ApplyGlow(Button btn)
        {
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);

            btn.MouseEnter += (s, e) =>
            {
                btn.ForeColor = Color.FromArgb(255, 122, 0); // neon orange
                btn.Invalidate();
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.ForeColor = Color.White;
                btn.Invalidate();
            };

            btn.Paint += (s, e) =>
            {
                if (btn.ClientRectangle.Contains(btn.PointToClient(Cursor.Position)))
                {
                    GlowHelper.DrawGlow(e.Graphics, btn.ClientRectangle, Color.FromArgb(255, 122, 0), 8, 0.35f);
                }
            };
        }
    }
}
