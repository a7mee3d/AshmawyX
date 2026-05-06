using System;
using System.Windows.Forms;

namespace AshmawyX
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnClose.Click += (s, e) => this.Close();
        }
    }
}
