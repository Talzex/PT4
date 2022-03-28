﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            animals = null; // Requete
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

        }

        /// <summary>
        /// Click on the "Valider" Button. Accepts the changes if posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateBTN_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
            if (LNameTB.Text != "" || FNameTB.Text != "" ||
                MailTB.Text != "" || PhoneTB.Text != "" ||
                !reg.IsMatch(MailTB.Text))
            {
                // Sauvegarder
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
                "Suppression", MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                //Supprimer
                DialogResult = DialogResult.Abort;
                Close();
            }
        }
    }
}
