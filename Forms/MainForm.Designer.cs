using System;
using System.Windows.Forms;
using System.Drawing;

namespace AshmawyX
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSub;

        private Button btnAbout;
        private Button btnSettings;

        private Label lblMain;
        private ComboBox cmbMain;
        private Button btnSetMain;
        private Label lblMainSet;

        private Label lblSecond;
        private ComboBox cmbSecond;
        private Button btnSetSecond;
        private Label lblSecondSet;

        private Button btnStart;
        private Button btnPause;
        private Button btnStop;

        private Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();

            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();

            this.lblMain = new System.Windows.Forms.Label();
            this.cmbMain = new System.Windows.Forms.ComboBox();
            this.btnSetMain = new System.Windows.Forms.Button();
            this.lblMainSet = new System.Windows.Forms.Label();

            this.lblSecond = new System.Windows.Forms.Label();
            this.cmbSecond = new System.Windows.Forms.ComboBox();
            this.btnSetSecond = new System.Windows.Forms.Button();
            this.lblSecondSet = new System.Windows.Forms.Label();

            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();

            this.lblStatus = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // FORM
            this.BackColor = Color.FromArgb(13, 13, 13);
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "AshmawyX";
            this.MaximizeBox = false;
            this.MinimizeBox = true;

            // TITLE
            this.lblTitle.Text = "ASHMAWYX";
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(255, 122, 0); // neon orange
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(115, 10);

            // SUBTITLE
            this.lblSub.Text = "Advanced AO Multibox Controller";
            this.lblSub.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblSub.ForeColor = Color.FromArgb(164, 92, 255); // neon purple
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new Point(80, 45);

            // ABOUT BUTTON (TOP-RIGHT)
            this.btnAbout.Text = "About";
            this.btnAbout.BackColor = Color.FromArgb(31, 31, 31);
            this.btnAbout.ForeColor = Color.White;
            this.btnAbout.FlatStyle = FlatStyle.Flat;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.Location = new Point(300, 10);
            this.btnAbout.Size = new Size(65, 25);

            // SETTINGS BUTTON (BOTTOM-LEFT)
            this.btnSettings.Text = "Settings";
            this.btnSettings.BackColor = Color.FromArgb(31, 31, 31);
            this.btnSettings.ForeColor = Color.White;
            this.btnSettings.FlatStyle = FlatStyle.Flat;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.Location = new Point(15, 260);
            this.btnSettings.Size = new Size(80, 35);

            // MAIN CLIENT LABEL
            this.lblMain.Text = "Main Client:";
            this.lblMain.ForeColor = Color.White;
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new Point(15, 95);

            // MAIN CLIENT COMBO
            this.cmbMain.Location = new Point(100, 92);
            this.cmbMain.Size = new Size(180, 23);
            this.cmbMain.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbMain.BackColor = Color.FromArgb(32, 32, 32);
            this.cmbMain.ForeColor = Color.White;
            this.cmbMain.FlatStyle = FlatStyle.Flat;

            // SET MAIN BUTTON
            this.btnSetMain.Text = "Set";
            this.btnSetMain.BackColor = Color.FromArgb(31, 31, 31);
            this.btnSetMain.ForeColor = Color.White;
            this.btnSetMain.FlatStyle = FlatStyle.Flat;
            this.btnSetMain.FlatAppearance.BorderSize = 0;
            this.btnSetMain.Location = new Point(290, 92);
            this.btnSetMain.Size = new Size(60, 23);

            // MAIN SET LABEL
            this.lblMainSet.Text = "✓ Set";
            this.lblMainSet.ForeColor = Color.Lime;
            this.lblMainSet.AutoSize = true;
            this.lblMainSet.Location = new Point(290, 118);
            this.lblMainSet.Visible = false;

            // SECOND CLIENT LABEL
            this.lblSecond.Text = "Second Client:";
            this.lblSecond.ForeColor = Color.White;
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new Point(15, 140);

            // SECOND CLIENT COMBO
            this.cmbSecond.Location = new Point(100, 137);
            this.cmbSecond.Size = new Size(180, 23);
            this.cmbSecond.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbSecond.BackColor = Color.FromArgb(32, 32, 32);
            this.cmbSecond.ForeColor = Color.White;
            this.cmbSecond.FlatStyle = FlatStyle.Flat;

            // SET SECOND BUTTON
            this.btnSetSecond.Text = "Set";
            this.btnSetSecond.BackColor = Color.FromArgb(31, 31, 31);
            this.btnSetSecond.ForeColor = Color.White;
            this.btnSetSecond.FlatStyle = FlatStyle.Flat;
            this.btnSetSecond.FlatAppearance.BorderSize = 0;
            this.btnSetSecond.Location = new Point(290, 137);
            this.btnSetSecond.Size = new Size(60, 23);

            // SECOND SET LABEL
            this.lblSecondSet.Text = "✓ Set";
            this.lblSecondSet.ForeColor = Color.Lime;
            this.lblSecondSet.AutoSize = true;
            this.lblSecondSet.Location = new Point(290, 163);
            this.lblSecondSet.Visible = false;

            // START BUTTON
            this.btnStart.Text = "Start (F7)";
            this.btnStart.BackColor = Color.FromArgb(0, 204, 0); // green neon
            this.btnStart.ForeColor = Color.White;
            this.btnStart.FlatStyle = FlatStyle.Flat;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Location = new Point(15, 200);
            this.btnStart.Size = new Size(100, 40);

            // PAUSE BUTTON
            this.btnPause.Text = "Pause (F8)";
            this.btnPause.BackColor = Color.FromArgb(230, 195, 0); // yellow neon
            this.btnPause.ForeColor = Color.White;
            this.btnPause.FlatStyle = FlatStyle.Flat;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.Location = new Point(135, 200);
            this.btnPause.Size = new Size(100, 40);

            // STOP BUTTON
            this.btnStop.Text = "Stop (F9)";
            this.btnStop.BackColor = Color.FromArgb(204, 0, 0); // red neon
            this.btnStop.ForeColor = Color.White;
            this.btnStop.FlatStyle = FlatStyle.Flat;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Location = new Point(255, 200);
            this.btnStop.Size = new Size(100, 40);

            // STATUS LABEL
            this.lblStatus.Text = "Ready";
            this.lblStatus.ForeColor = Color.FromArgb(164, 92, 255); // neon purple
            this.lblStatus.Location = new Point(10, 300);
            this.lblStatus.Size = new Size(360, 18);
            this.lblStatus.TextAlign = ContentAlignment.MiddleCenter;

            // ADD CONTROLS
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSub);

            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSettings);

            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.cmbMain);
            this.Controls.Add(this.btnSetMain);
            this.Controls.Add(this.lblMainSet);

            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.cmbSecond);
            this.Controls.Add(this.btnSetSecond);
            this.Controls.Add(this.lblSecondSet);

            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);

            this.Controls.Add(this.lblStatus);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
