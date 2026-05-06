namespace AshmawyX
{
    partial class KeyCaptureForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // FORM
            this.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            this.ClientSize = new System.Drawing.Size(260, 90);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Press a key";
            this.KeyPreview = true;

            // LABEL
            this.lblInfo.Text = "Press any key...";
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.Orange;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(65, 30);

            // ADD CONTROLS
            this.Controls.Add(this.lblInfo);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
    }
}
