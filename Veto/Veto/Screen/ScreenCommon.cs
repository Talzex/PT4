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

    public partial class ScreenCommon : Veto.ScreenBase
    {
        protected Salarie user;

        public ScreenCommon() { InitializeComponent(); }

        public ScreenCommon(Salarie user)
        {
            InitializeComponent();
            this.user = user;
            UserLBL.Text = user.Login;
        }

        /// <summary>
        /// Before the screen is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreenCommon_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormController.ScreenClosed(this.DialogResult);
        }

        /// <summary>
        /// Click on the "Deconnexion" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisconnectBT_Click(object sender, EventArgs e)
        {
            FormController.Disconnect();
        }
    }
}
