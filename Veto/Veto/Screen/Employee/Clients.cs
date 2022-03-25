using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class Clients : Veto.ScreenEmployee
    {

        private List<Client> allClients;

        private int page;
        private int pageSize;

        public Clients() { InitializeComponent(); }

        public Clients(Salarie user) : base(user)
        {
            InitializeComponent();
        }

        public void RefreshItems()
        {
            if (allClients == null)
            {
                allClients = Utils.GetClientsAll();
            }
            for (int i = page * pageSize; i < (page + 1) * pageSize || i < allClients.Count; i++)
            {

            }
        }

        private void Clients_Activated(object sender, EventArgs e)
        {
            page = 0;
            PrevPageBTN.Enabled = false;
            RefreshItems();
        }

        private void PrevPageBTN_Click(object sender, EventArgs e)
        {
            page--;

            NextPageBTN.Enabled = true;
        }

        private void NextPageBTN_Click(object sender, EventArgs e)
        {
            page++;
            PrevPageBTN.Enabled = true;
        }
    }
}
