using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private void ConnectionAttempt()
        {
            if (LoginTB.Text != "" && PasswordTB.Text != "")
            {
                // GetUser
                Salarie s = new Salarie();
                if (s != null)
                {
                    //Rôle admin
                    if ()

                    //
                }
                else
                {
                    MessageBox.Show("Erreur");
                }

            }
            else
            {
                MessageBox.Show("Erreur");
            }
        }
    }
}
