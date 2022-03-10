using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class ScreenEmployee : Veto.ScreenCommon
    {

        public ScreenEmployee() { InitializeComponent(); }


        public ScreenEmployee(Salarie user) : base(user)
        {
            InitializeComponent();
        }

        private void CalendarBTN_Click(object sender, EventArgs e)
        {
            FormController.GetController().ActivateForm(0);
        }

        private void StocksBTN_Click(object sender, EventArgs e)
        {
            FormController.GetController().ActivateForm(2);
        }

        private void ClientsBTN_Click(object sender, EventArgs e)
        {
            FormController.GetController().ActivateForm(1);
        }

        private void CartBTN_Click(object sender, EventArgs e)
        {
            FormController.GetController().ActivateForm(3);
        }

        private void StatsBTN_Click(object sender, EventArgs e)
        {
            FormController.GetController().ActivateForm(4);
        }

    }
}
