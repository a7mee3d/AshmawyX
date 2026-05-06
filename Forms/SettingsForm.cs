using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AshmawyX
{
    public partial class SettingsForm : Form
    {
        public AppSettings ReturnedSettings { get; private set; }

        private AppSettings localSettings;

        public SettingsForm(AppSettings settings)
        {
            InitializeComponent();

            // Clone settings so changes are not applied until Save
            localSettings = settings.Clone();

            LoadSettingsIntoUI();
            WireEvents();
            ApplyGlowToAll();
        }

        // ---------------------------------------------------------
        // LOAD SETTINGS INTO UI
        // ---------------------------------------------------------
        private void LoadSettingsIntoUI()
        {
            chkDelay.Checked = localSettings.DelayEnabled;
            numMin.Value = (decimal)localSettings.MinDelay;
            numMax.Value = (decimal)localSettings.MaxDelay;

            lstKeys.Items.Clear();
            foreach (var k in localSettings.BlockedKeys)
                lstKeys.Items.Add(k);
        }

        // ---------------------------------------------------------
        // SAVE UI INTO SETTINGS
        // ---------------------------------------------------------
        private void SaveUIToSettings()
        {
            localSettings.DelayEnabled = chkDelay.Checked;
            localSettings.MinDelay = (double)numMin.Value;
            localSettings.MaxDelay = (double)numMax.Value;

            localSettings.BlockedKeys = lstKeys.Items.Cast<Keys>().ToList();
        }

        // ---------------------------------------------------------
        // EVENT WIRING
        // ---------------------------------------------------------
        private void WireEvents()
        {
            btnAddKey.Click += BtnAddKey_Click;
            btnRemoveKey.Click += BtnRemoveKey_Click;
            btnClearKeys.Click += BtnClearKeys_Click;

            btnSave.Click += BtnSave_Click;
            btnClose.Click += (s, e) => this.Close();
        }

        // ---------------------------------------------------------
        // ADD KEY
        // ---------------------------------------------------------
        private void BtnAddKey_Click(object sender, EventArgs e)
        {
            using (var kc = new KeyCaptureForm())
            {
                if (kc.ShowDialog() == DialogResult.OK)
                {
                    if (!lstKeys.Items.Contains(kc.CapturedKey))
                    {
                        lstKeys.Items.Add(kc.CapturedKey);
                    }
                }
            }
        }

        // ---------------------------------------------------------
        // REMOVE KEY
        // ---------------------------------------------------------
        private void BtnRemoveKey_Click(object sender, EventArgs e)
        {
            if (lstKeys.SelectedItem != null)
            {
                lstKeys.Items.Remove(lstKeys.SelectedItem);
            }
        }

        // ---------------------------------------------------------
        // CLEAR KEYS
        // ---------------------------------------------------------
        private void BtnClearKeys_Click(object sender, EventArgs e)
        {
            lstKeys.Items.Clear();
        }

        // ---------------------------------------------------------
        // SAVE BUTTON
        // ---------------------------------------------------------
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveUIToSettings();
            ReturnedSettings = localSettings.Clone();

            SettingsManager.Save(ReturnedSettings);

            this.Close();
        }

        // ---------------------------------------------------------
        // APPLY SOFT GLOW TO BUTTONS
        // ---------------------------------------------------------
        private void ApplyGlowToAll()
        {
            ApplyGlow(btnAddKey);
            ApplyGlow(btnRemoveKey);
            ApplyGlow(btnClearKeys);
            ApplyGlow(btnSave);
            ApplyGlow(btnClose);
        }

        private void ApplyGlow(Button btn)
        {
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);

            btn.MouseEnter += (s, e) =>
            {
                btn.ForeColor = Color.FromArgb(255, 122, 0);
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
