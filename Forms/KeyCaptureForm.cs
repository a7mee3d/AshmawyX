using System;
using System.Windows.Forms;

namespace AshmawyX
{
    public partial class KeyCaptureForm : Form
    {
        public Keys CapturedKey { get; private set; }

        public KeyCaptureForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += KeyCaptureForm_KeyDown;
        }

        private void KeyCaptureForm_KeyDown(object sender, KeyEventArgs e)
        {
            CapturedKey = e.KeyCode;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
