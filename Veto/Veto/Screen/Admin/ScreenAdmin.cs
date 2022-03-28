using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Veto
{
    public partial class ScreenAdmin : Veto.ScreenCommon
    {

        public ScreenAdmin() { InitializeComponent(); }

        public ScreenAdmin(Salarie user) : base(user)
        {
            InitializeComponent();
            //SidePNL.Visible = true;
        }

        /// <summary>
        /// Shows the screen that lists all the employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserBTN_Click(object sender, EventArgs e)
        {
            FormController.GetController().ActivateForm(0);
        }

        /// <summary>
        /// Shows the screen that lists the logs (Not implemented)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogsBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
