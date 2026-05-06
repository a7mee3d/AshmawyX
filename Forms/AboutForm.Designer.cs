using System.Drawing;
using System.Windows.Forms;

namespace AshmawyX
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblDescription;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblDescription = new Label();
            this.btnClose = new Button();

            this.SuspendLayout();

            // FORM
            this.BackColor = Color.FromArgb(13, 13, 13);
            this.ClientSize = new Size(520, 480);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "About AshmawyX";
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // TITLE
            this.lblTitle.Text = "AshmawyX — About";
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(255, 122, 0);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(150, 20);

            // DESCRIPTION
            this.lblDescription.Text =
                "AshmawyX is a fast and simple multibox key mirroring tool.\n" +
                "\n" +
                "🔶 What the app does:\n" +
                "• Mirrors your key presses from the main client to the second client.\n" +
                "• Works with perfect timing, stability, and low CPU usage.\n" +
                "\n" +
                "🔶 Default mirrored keys:\n" +
                "• 0–9\n" +
                "• NumPad 0–9\n" +
                "• F1–F6\n" +
                "• Shift (supports Shift + Number combos)\n" +
                "\n" +
                "🔶 Custom mirror keys:\n" +
                "• Add any extra key you want from the Settings window.\n" +
                "• Example: Q, E, R, Space, Ctrl, Alt, arrows, etc.\n" +
                "\n" +
                "🔶 Hotkeys (control the app):\n" +
                "• F7 → Start\n" +
                "• F8 → Pause\n" +
                "• F9 → Stop\n" +
                "\n" +
                "🔶 Delay system:\n" +
                "• Optional random delay between main and second client.\n" +
                "• Uses Min Delay and Max Delay values.\n" +
                "\n" +
                "🔶 Chat‑safe mode:\n" +
                "• Enter is blocked to prevent sending messages to the wrong window.\n" +
                "\n" +
                "Created by: Ahmed Ashmawy\n" +
                "Version: 1.0.0";
            this.lblDescription.Font = new Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = Color.White;
            this.lblDescription.AutoSize = false;
            this.lblDescription.Size = new Size(460, 380);
            this.lblDescription.Location = new Point(30, 70);

            // CLOSE BUTTON
            this.btnClose.Text = "Close";
            this.btnClose.BackColor = Color.FromArgb(31, 31, 31);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new Point(210, 430);
            this.btnClose.Size = new Size(100, 35);

            this.btnClose.Click += (s, e) => this.Close();

            // ADD CONTROLS
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
