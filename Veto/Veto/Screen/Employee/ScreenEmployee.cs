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
            ChangeCurrentScreen(0);
        }

        private void StocksBTN_Click(object sender, EventArgs e)
        {
            ChangeCurrentScreen(2);

        }

        private void ClientsBTN_Click(object sender, EventArgs e)
        {
            ChangeCurrentScreen(1);

        }

        private void CartBTN_Click(object sender, EventArgs e)
        {
            ChangeCurrentScreen(3);

        }

        private void StatsBTN_Click(object sender, EventArgs e)
        {
            ChangeCurrentScreen(4);

        }

        private void ChangeCurrentScreen(int screenIndex)
        {
            Form f = FormController.GetController().GetForm(screenIndex);
            ChangeScreen(f);
        }

    }
}
