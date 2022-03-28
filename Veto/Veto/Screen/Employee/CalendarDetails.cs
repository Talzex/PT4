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
        }

        public CalendarDetails(RendezVous rdv)
        {
            InitializeComponent();
            this.rdv = rdv;
            this.ClientsList.SelectedItem = rdv.Client;
            this.AnimalsList.SelectedItem = rdv.AnimalRDV;
            this.BeginHour.Value = rdv.heureDebut.Hours;
            this.EndHour.Value = rdv.heureFin.Hours;
            this.Date.SelectionRange.Start = rdv.Journee.Date;
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
                rdv.Client = (Client)this.ClientsList.SelectedItem;
                rdv.AnimalRDV = (ICollection<AnimalRDV>)(Animal)this.AnimalsList.SelectedItem;
                rdv.heureDebut = new TimeSpan((int)this.BeginHour.Value, 0, 0);
                rdv.heureFin = new TimeSpan((int)this.EndHour.Value, 0, 0);
                rdv.motif = ReasonTB.Text;
                rdv.Journee = journee;
                Utils.SaveRDV(rdv);
            }
            else
            {
                Client client = (Client)this.ClientsList.SelectedItem;
                Animal animal = (Animal)(ICollection<AnimalRDV>)this.AnimalsList.SelectedItem;
                Utils.ModifyRDV(rdv, client.IdClient, animal,
                    new TimeSpan((int)this.BeginHour.Value, 0, 0), new TimeSpan((int)this.EndHour.Value, 0, 0), ReasonTB.Text.ToString(), journee.IdJournee);
            }
        }
    }
}
