using System.Drawing;
using System.Windows.Forms;

namespace AshmawyX
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblDelay;
        private CheckBox chkDelay;

        private Label lblMin;
        private NumericUpDown numMin;

        private Label lblMax;
        private NumericUpDown numMax;

        private Label lblKeys;
        private ListBox lstKeys;

        private Button btnAddKey;
        private Button btnRemoveKey;
        private Button btnClearKeys;

        private Button btnSave;
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
            this.components = new System.ComponentModel.Container();

            this.lblTitle = new Label();
            this.lblDelay = new Label();
            this.chkDelay = new CheckBox();

            this.lblMin = new Label();
            this.numMin = new NumericUpDown();

            this.lblMax = new Label();
            this.numMax = new NumericUpDown();

            this.lblKeys = new Label();
            this.lstKeys = new ListBox();

            this.btnAddKey = new Button();
            this.btnRemoveKey = new Button();
            this.btnClearKeys = new Button();

            this.btnSave = new Button();
            this.btnClose = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();

            this.SuspendLayout();

            // FORM
            this.BackColor = Color.FromArgb(13, 13, 13);
            this.ClientSize = new Size(420, 420);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // TITLE
            this.lblTitle.Text = "Settings";
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(255, 122, 0);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(160, 15);

            // DELAY LABEL
            this.lblDelay.Text = "Enable Delay:";
            this.lblDelay.ForeColor = Color.White;
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new Point(25, 70);

            // DELAY CHECKBOX
            this.chkDelay.AutoSize = true;
            this.chkDelay.Checked = true;
            this.chkDelay.ForeColor = Color.White;
            this.chkDelay.Location = new Point(130, 70);

            // MIN DELAY LABEL
            this.lblMin.Text = "Min Delay:";
            this.lblMin.ForeColor = Color.White;
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new Point(25, 110);

            // MIN DELAY NUMERIC
            this.numMin.DecimalPlaces = 1;
            this.numMin.Increment = 0.1M;
            this.numMin.Minimum = 0.1M;
            this.numMin.Maximum = 5;
            this.numMin.Value = 0.2M;
            this.numMin.BackColor = Color.FromArgb(32, 32, 32);
            this.numMin.ForeColor = Color.White;
            this.numMin.Location = new Point(130, 108);
            this.numMin.Size = new Size(80, 23);

            // MAX DELAY LABEL
            this.lblMax.Text = "Max Delay:";
            this.lblMax.ForeColor = Color.White;
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new Point(25, 150);

            // MAX DELAY NUMERIC
            this.numMax.DecimalPlaces = 1;
            this.numMax.Increment = 0.1M;
            this.numMax.Minimum = 0.1M;
            this.numMax.Maximum = 5;
            this.numMax.Value = 0.8M;
            this.numMax.BackColor = Color.FromArgb(32, 32, 32);
            this.numMax.ForeColor = Color.White;
            this.numMax.Location = new Point(130, 148);
            this.numMax.Size = new Size(80, 23);

            // KEYS LABEL
            this.lblKeys.Text = "Blocked Keys:";
            this.lblKeys.ForeColor = Color.White;
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new Point(25, 200);

            // KEYS LISTBOX
            this.lstKeys.BackColor = Color.FromArgb(25, 25, 25);
            this.lstKeys.ForeColor = Color.White;
            this.lstKeys.Location = new Point(25, 225);
            this.lstKeys.Size = new Size(150, 150);

            // ADD KEY BUTTON
            this.btnAddKey.Text = "Add Key";
            this.btnAddKey.BackColor = Color.FromArgb(31, 31, 31);
            this.btnAddKey.ForeColor = Color.White;
            this.btnAddKey.FlatStyle = FlatStyle.Flat;
            this.btnAddKey.FlatAppearance.BorderSize = 0;
            this.btnAddKey.Location = new Point(200, 225);
            this.btnAddKey.Size = new Size(90, 30);

            // REMOVE KEY BUTTON
            this.btnRemoveKey.Text = "Remove";
            this.btnRemoveKey.BackColor = Color.FromArgb(31, 31, 31);
            this.btnRemoveKey.ForeColor = Color.White;
            this.btnRemoveKey.FlatStyle = FlatStyle.Flat;
            this.btnRemoveKey.FlatAppearance.BorderSize = 0;
            this.btnRemoveKey.Location = new Point(200, 265);
            this.btnRemoveKey.Size = new Size(90, 30);

            // CLEAR KEYS BUTTON
            this.btnClearKeys.Text = "Clear";
            this.btnClearKeys.BackColor = Color.FromArgb(31, 31, 31);
            this.btnClearKeys.ForeColor = Color.White;
            this.btnClearKeys.FlatStyle = FlatStyle.Flat;
            this.btnClearKeys.FlatAppearance.BorderSize = 0;
            this.btnClearKeys.Location = new Point(200, 305);
            this.btnClearKeys.Size = new Size(90, 30);

            // SAVE BUTTON
            this.btnSave.Text = "Save";
            this.btnSave.BackColor = Color.FromArgb(0, 204, 0);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new Point(300, 330);
            this.btnSave.Size = new Size(90, 35);

            // CLOSE BUTTON
            this.btnClose.Text = "Close";
            this.btnClose.BackColor = Color.FromArgb(204, 0, 0);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new Point(300, 280);
            this.btnClose.Size = new Size(90, 35);

            // ADD CONTROLS
            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.chkDelay);

            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.numMin);

            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.numMax);

            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.lstKeys);

            this.Controls.Add(this.btnAddKey);
            this.Controls.Add(this.btnRemoveKey);
            this.Controls.Add(this.btnClearKeys);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
