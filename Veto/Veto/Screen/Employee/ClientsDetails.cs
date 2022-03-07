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
    public partial class ClientsDetails : Form
    {
        private Client client;
        public ClientsDetails(Client client)
        {
            InitializeComponent();
            this.client = client;
        }
    }
}
