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
        private Salarie user;

        public ScreenCommon(Salarie user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EcranCommun_Load(object sender, EventArgs e)
        {

        }

        private void DisconnectBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScreenConection conection = new ScreenConection();
            conection.Closed += (s, args) => this.Show();
            conection.Show();
        }
    }
}
