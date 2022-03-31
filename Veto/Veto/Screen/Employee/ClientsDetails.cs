using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    public partial class ClientsDetails : Form
    {
        private Client client;
        private List<Animal> animals;

        /// <summary>
        /// Create a new Client
        /// </summary>
        public ClientsDetails()
        {
            InitializeComponent();
            client = new Client();
        }

        /// <summary>
        /// Show details of clients
        /// </summary>
        /// <param name="client">The client to show</param>
        public ClientsDetails(Client client)
        {
            InitializeComponent();
            this.client = client;
            animals = Utils.ClientAnimals(client); // Requete
            UpdateDisplay();
        }

        /// <summary>
        /// Updates the labels
        /// </summary>
        private void UpdateDisplay()
        {
            LNameTB.Text = client.NomClient;
            FNameTB.Text = client.PrenomClient;
            MailTB.Text = client.AdresseMail;
            PhoneTB.Text = client.NumeroTelephone;
            if (animals.Count > 0)
            {
                foreach (Animal a in animals)
                {
                    AnimalsPNL.Controls.Add(new AnimalComponent(a));
                }
            }
        }

        /// <summary>
        /// Click on the "Ajouter animal" Button. Adds an animal to the client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAnimalBTN_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            AnimalDetails f = new AnimalDetails(a);
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {

            }
            else if (res == DialogResult.Abort)
            {

            }
        }

        /// <summary>
        /// Click on the "Valider" Button. Accepts the changes if posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateBTN_Click(object sender, EventArgs e)
        {
            if (LNameTB.Text != "" && FNameTB.Text != "" &&
                MailTB.Text != "" && PhoneTB.Text != "" &&
                IsValidMail(MailTB.Text) && PhoneTB.Text.Length == 10)
            {
                client.AdresseMail = MailTB.Text;
                client.NomClient = LNameTB.Text;
                client.PrenomClient = FNameTB.Text;
                client.NumeroTelephone = PhoneTB.Text;
                Utils.SaveClient(client);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Les champs doivent être non nuls et l'adresse mail doit être valide");
            }
        }

        /// <summary>
        /// Click on the "Supprimer" Button. Deletes the Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous allez supprimer le client. En êtes vous sûr ?",
                "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void PhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private bool IsValidMail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
