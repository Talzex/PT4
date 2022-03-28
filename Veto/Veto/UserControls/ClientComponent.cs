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
    public partial class ClientComponent : UserControl
    {
        private Client client;

        public ClientComponent(Client client)
        {
            InitializeComponent();
            this.client = client;
            UpdateDisplay();
        }

        /// <summary>
        /// Click on the "Détails" Button. Shows a new form with the client's details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailsButton_Click(object sender, EventArgs e)
        {
            ClientsDetails cd = new ClientsDetails(client);
            DialogResult result = cd.ShowDialog();
            if (result == DialogResult.Abort)
            {
                Parent.Controls.Remove(this);
                Utils.RemoveClient(client);
            } else if (result == DialogResult.OK)
            {
                UpdateDisplay();
            }
        }

        /// <summary>
        /// Updates the labels
        /// </summary>
        public void UpdateDisplay()
        {
            NameLBL.Text = client.ToString();
            TelLBL.Text = "Téléphone : " + client.NumeroTelephone;
            EmailLBL.Text = "Email : " + client.AdresseMail;
        }
    }
}
