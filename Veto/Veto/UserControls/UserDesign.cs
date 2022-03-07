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
        private Panel parent;

        public UserDesign(Salarie employee, Panel parentPanel)
        {
            InitializeComponent();
            this.employee = employee;
            parent = parentPanel;
            UpdateElements();
        }

        /// <summary>
        /// Click on the "Détails" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailsBTN_Click(object sender, EventArgs e)
        {
            ShowModificatationForm();
        }

        public void ShowModificatationForm()
        {
            UserDetails user = new UserDetails(employee);
            DialogResult res = user.ShowDialog();

            if (res == DialogResult.OK)
            {
                // Sauvegarder l'utilisateur
                if (!parent.Controls.Contains(this))
                {
                    parent.Controls.Add(this);
                }
            }
            else
            {
                // Supprimer user
                parent.Controls.Remove(this);
            }
        }

        public void UpdateElements()
        {
            DescLBL.Text = employee.Login + " | " + employee.Roles;
        }
    }
}
