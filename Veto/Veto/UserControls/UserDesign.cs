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
        private FlowLayoutPanel panel;

        public UserDesign(Salarie employee, FlowLayoutPanel parentPanel)
        {
            InitializeComponent();
            this.employee = employee;
            panel = parentPanel;
            UpdateElements();
        }

        /// <summary>
        /// Click on the "Détails" Button. Shows a new form with the user's details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailsBTN_Click(object sender, EventArgs e)
        {
            ShowModificatationForm();
        }

        /// <summary>
        /// Form with the user's details
        /// </summary>
        public void ShowModificatationForm()
        {
            UserDetails user = new UserDetails(employee);
            DialogResult res = user.ShowDialog();

            if (res == DialogResult.OK)
            {
                // Sauvegarder l'utilisateur
                if (!panel.Controls.Contains(this))
                {
                    panel.Controls.Add(this);
                }
                UserList parent = (UserList)ParentForm;
                parent.LoadUsers();
            }
            else if (res ==DialogResult.Abort)
            {
                // Supprimer user
                panel.Controls.Remove(this);
            }
        }

        /// <summary>
        /// Update the elements
        /// </summary>
        public void UpdateElements()
        {
            DescLBL.Text = employee.Login + " | " + employee.Roles;
        }
    }
}
