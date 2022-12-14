using System;
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
        private bool create;

        public UserDetails()
        {
            InitializeComponent();
        }

        public UserDetails(Salarie employee)
        {
            InitializeComponent();
            if (employee != null)
            {
                create = false;
                this.employee = employee;
                FillTextBoxes();
            }
            else
            {
                create = true;
                this.employee = new Salarie();
            }
            AddRoles();
        }

        /// <summary>
        /// Loads the employees' infos in the textboxes
        /// </summary>
        private void FillTextBoxes()
        {
            LoginTB.Text = employee.Login;
            PasswordTB.Text = employee.MDP;
            MailTB.Text = employee.Mail;
            RoleCB.SelectedItem = employee.Roles;
        }

        /// <summary>
        /// Adds the availbles roles into the combobox
        /// </summary>
        private void AddRoles()
        {
            List<Roles> roles = Utils.GetRolesAll();
            foreach (Roles r in roles)
            {
                RoleCB.Items.Add(r);
            }
        }

        /// <summary>
        /// Saves the employee's infos if they are correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            }
            else
            {
                employee.Login = LoginTB.Text;
                employee.MDP = PasswordTB.Text;
                employee.IdRoles = (RoleCB.SelectedItem as Roles).IdRoles;
                employee.Mail = MailTB.Text;
                employee.Roles = RoleCB.SelectedItem as Roles;
                if (create)
                {
                    Utils.SaveEmployee(employee);
                } else
                {
                    Utils.ModifyEmployee(employee);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Deletes the employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Vous allez supprimer cet utiilisateur, en êtes-vous sûr ?", "Oui / Non", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }
    }
}
