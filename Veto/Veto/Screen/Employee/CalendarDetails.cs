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
    public partial class CalendarDetails : Form
    {
        private RendezVous rdv = null;

        public CalendarDetails()
        {
            InitializeComponent();
            error.Text = "";
            fillClients();
        }

        public CalendarDetails(RendezVous rdv)
        {
            InitializeComponent();
            error.Text = "";
            fillClients();
            this.rdv = rdv;
            this.ClientsList.SelectedItem = rdv.Client;
            
            this.BeginHour.Value = rdv.heureDebut.Hours;
            this.EndHour.Value = rdv.heureFin.Hours;
            this.ReasonTB.Text = rdv.motif;
            AnimalRDV a = Utils.getAnimalRDV(rdv);
            Animal animal = a.Animal;
            this.AnimalsList.SelectedItem = animal.Nom;
            this.montantTB.Text = a.Montant.ToString();
        }

        private void fillClients()
        {
             List<Client> clients = Utils.GetClientsAll();
            foreach (Client client in clients)
            {
                ClientsList.Items.Add(client);
            }
        }

        /// <summary>
        /// Close the window without register the modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Close the window and register the modification on the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateBT_Click(object sender, EventArgs e)
        {
            Journee journee = null;
            if (Utils.GetDay(Date.SelectionRange.Start) == null)
            {
                journee = new Journee();
                journee.Date = Date.SelectionRange.Start;
                Utils.SaveDay(journee);
            }
            else
            {
                journee = Utils.GetDay(Date.SelectionRange.Start);
            }

            if (this.rdv == null)
            {
                rdv = new RendezVous();
                rdv.Client = (Client)ClientsList.SelectedItem;
                rdv.heureDebut = new TimeSpan((int)BeginHour.Value, 0, 0);
                rdv.heureFin = new TimeSpan((int)EndHour.Value, 0, 0);
                rdv.motif = ReasonTB.Text;
                rdv.Journee = journee;
                

                if (valid(rdv))
                {
                    Utils.SaveRDV(rdv);
                    Animal animal = Utils.getAnimal(rdv.Client, (String)AnimalsList.SelectedItem);
                    AnimalRDV animalRDV = new AnimalRDV();
                    animalRDV.IdRDV = rdv.idRdv;
                    animalRDV.IdAnimal = animal.IdAnimal;
                    animalRDV.Montant = montantTB.Value;

                    Utils.SaveAnimalRDV(animalRDV);
                    this.Close();
                }
            }
            else
            {

                if (valid(rdv))
                {
                    Animal animal = Utils.getAnimal(rdv.Client, (String)AnimalsList.SelectedItem);
                    Client client = (Client)ClientsList.SelectedItem;

                    Utils.ModifyRDV(rdv, client.IdClient,new TimeSpan((int)BeginHour.Value, 0, 0), new TimeSpan((int)EndHour.Value, 0, 0), ReasonTB.Text.ToString(), journee.IdJournee);
                    Utils.modifyAnimalRDV(Utils.getAnimalRDV(rdv), rdv.idRdv, animal.IdAnimal);
                    this.Close();
                }
            }

          
        }

        private void ClientsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalsList.Items.Clear();
            Client client = (Client)ClientsList.SelectedItem;
            List<Animal> animals = Utils.getClientAnimals(client);
            foreach (Animal animal in animals)
            {
                AnimalsList.Items.Add(animal.Nom);
            }
        }

        private bool valid(RendezVous rdv)
        {
            bool valid = true;

            if ((int)BeginHour.Value < 9 || (int)BeginHour.Value > 17 || (int)EndHour.Value < 10 || (int)EndHour.Value > 18)
            {
                valid = false;
                error.BackColor = Color.Red;
                error.Text = "Horaires non conformes !";
            }

            List<RendezVous> rdvs = Utils.getAllRDV();
            foreach (RendezVous r in rdvs)
            {
                if (r.Journee.Date.Equals(rdv.Journee.Date) && r.heureDebut.Equals(rdv.heureDebut) && r.idRdv != rdv.idRdv)
                {
                    valid = false;
                    error.BackColor = Color.Red;
                    error.Text = "Il existe déjà un RDV pour ce créneau !";
                }
            }

            if ((Client)ClientsList.SelectedItem == null || (String)AnimalsList.SelectedItem == null || ReasonTB.Text.Equals(""))
            {
                valid = false;
                error.BackColor = Color.Red;
                error.Text = "Tous les champs ne sont pas sélectionnés ou remplis !";
            }

            return valid;
        }
    }
}
