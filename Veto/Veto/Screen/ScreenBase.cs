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

        /// <summary>
        /// Execute a series of action to open an other form
        /// </summary>
        /// <param name="other">The other Form to open</param>
        /// <returns></returns>
        protected DialogResult ChangeScreen(Form other, bool hide)
        {
            other.Location = this.Location;
            other.StartPosition = FormStartPosition.Manual;
            other.FormClosing += delegate { this.Show(); };
            if (hide)
                this.Hide();
            else
                this.Close();
            DialogResult res = other.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                this.Close();
            }
            return other.ShowDialog();

        }
    }
}
