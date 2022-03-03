using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    public partial class ScreenBase : Form
    {
        public ScreenBase()
        {
            InitializeComponent();
        }

        protected void ChangeScreen(ScreenBase other)
        {
            other.Location = this.Location;
            other.StartPosition = FormStartPosition.Manual;
            other.FormClosing += delegate { this.Show(); };
            other.Show();
            this.Hide();
        }
    }
}
