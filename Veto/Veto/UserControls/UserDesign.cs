﻿using System;
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
        private Panel panel;

        public UserDesign(Salarie employee, Panel parentPanel)
        {
            InitializeComponent();
            this.employee = employee;
            panel = parentPanel;
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

        public void UpdateElements()
        {
            DescLBL.Text = employee.Login + " | " + employee.Roles;
        }
    }
}
