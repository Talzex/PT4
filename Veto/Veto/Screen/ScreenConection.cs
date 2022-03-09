using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Veto
{
    public partial class ScreenConection : Veto.ScreenBase
    {

        public ScreenConection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click on the button "Connexion"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectBT_Click(object sender, EventArgs e)
        {
            ConnectionAttempt();
        }

        /// <summary>
        /// Connection of the user
        /// </summary>
        private void ConnectionAttempt()
        {
            if (LoginTB.Text != "" && PasswordTB.Text != "")
            {
                // GetUser
                Salarie s = Utils.GetSalarie(LoginTB.Text.Trim(), PasswordTB.Text.Trim());
                if (s != null)
                {
                    this.Hide();
                    FormController.CreateScreens(s.IdRoles == 3, s);
                }
                else
                {
                    EmptyFields();
                    MessageBox.Show("Pas d'utilisateur trouvé");
                }

            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs");
            }
        }

        /// <summary>
        /// Empties the login and password fields
        /// </summary>
        private void EmptyFields()
        {
            LoginTB.Text = "";
            PasswordTB.Text = "";
        }

        /// <summary>
        /// Triggers once when the form is on the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreenConection_Activated(object sender, EventArgs e)
        {
            EmptyFields();
        }
    }
}
