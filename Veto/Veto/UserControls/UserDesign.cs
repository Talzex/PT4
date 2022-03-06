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
    public partial class UserDesign : UserControl
    {

        private Salarie employee;

        public UserDesign(Salarie employee)
        {
            InitializeComponent();
            this.employee = employee;
            DescLBL.Text = employee.Login + " | " + employee.Roles;
        }

        /// <summary>
        /// Click on the "Détails" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailsBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
