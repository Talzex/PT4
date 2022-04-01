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
        private int pageSize = 5;


        public Clients() { InitializeComponent(); }

        public Clients(Salarie user) : base(user)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the Items in the center panel
        /// </summary>
        private void RefreshItems()
        {
            if (allClients == null)
            {
                allClients = Utils.GetClientsAll();
            }
            ItemsPNL.Controls.Clear();
            for (int i = page * pageSize; i < (page + 1) * pageSize && i < allClients.Count; i++)
            {
                var component = new ClientComponent(allClients[i], ItemsPNL);
                ItemsPNL.Controls.Add(component);
            }
        }

        /// <summary>
        /// Activates when the form shows on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clients_Activated(object sender, EventArgs e)
        {
            ReloadPage();
        }

        /// <summary>
        /// Method to reload page 
        /// </summary>
        public void ReloadPage()
        {
            page = 0;
            allClients = Utils.GetClientsAll();
            RefreshItems();
            PrevPageBTN.Enabled = false;
            if (allClients.Count <= pageSize)
            {
                NextPageBTN.Enabled = false;
            }
        }

        /// <summary>
        /// Click on the Previous Page Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevPageBTN_Click(object sender, EventArgs e)
        {
            page--;

            if (page <= 0)
            {
                PrevPageBTN.Enabled = false;
            }

            NextPageBTN.Enabled = true;
            RefreshItems();
        }

        /// <summary>
        /// Click on the Next Page Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextPageBTN_Click(object sender, EventArgs e)
        {
            page++;

            if ((page + 1) * pageSize >= allClients.Count)
            {
                NextPageBTN.Enabled = false;
            }

            PrevPageBTN.Enabled = true;
            RefreshItems();
        }

        /// <summary>
        /// Click on the "Ajouter un client" Button. Adds a new client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClientBTN_Click(object sender, EventArgs e)
        {
            Client c = null;
            ClientsDetails form = new ClientsDetails(c);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ReloadPage();
            }
        }
    }
}
