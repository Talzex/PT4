using System;
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
    public partial class ClientDisplay : UserControl
    {
        private Client client;

        public ClientDisplay(Client client)
        {
            InitializeComponent();
            this.client = client;
            NameLBL.Text = client.ToString();
        }


        private void DetailsBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
