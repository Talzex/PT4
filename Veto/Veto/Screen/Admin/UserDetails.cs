﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    public partial class UserDetails : Form
    {

        private Salarie employee;

        public UserDetails()
        {
            InitializeComponent();
            employee = new Salarie();
            AddRoles();
        }

        public UserDetails(Salarie employee)
        {
            InitializeComponent();
            this.employee = employee;
            AddRoles();
        }

        private void AddRoles()
        {
            /*
            List<Roles> roles = null;
            foreach (Roles r in roles)
            {
                RoleCB.Items.Add(r);
            }*/
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
            if (LoginTB.Text == "")
            {
                MessageBox.Show("Le login ne doit pas être nul");
            }
            else if (PasswordTB.Text == "")
            {
                MessageBox.Show("Le mot de passe ne doit pas être nul");
            }
            else if (MailTB.Text == "" || !reg.IsMatch(MailTB.Text))
            {
                MessageBox.Show("L'adresse mail ne doit pas être nul et doit être valide");
            }
            else if (RoleCB.SelectedItem == null)
            {
                MessageBox.Show("L'utilisateur doit avoir un rôle");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Vous allez supprimer cet utiilisateur, en êtes-vous sûr ?", "Oui / Non", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }
    }
}
