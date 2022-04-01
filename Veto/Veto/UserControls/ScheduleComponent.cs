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
    public partial class Schedule : UserControl
    {
        private RendezVous rdv;
        private Animal animal;

        /// <summary>
        // Schedule class constructor
        /// </summary>
        /// <param name="rdv">the rendez-vous</param>
        /// <param name="animal">the animal</param>
        public Schedule(RendezVous rdv, Animal animal)
        {
            InitializeComponent();
            this.rdv = rdv;
            this.animal = animal;
            MAJSchedule(rdv, animal);
        }

        /// <summary>
        /// Schedule class constructor, whitout parameter
        /// </summary>
        public Schedule()
        {
            InitializeComponent();
            this.rdv = null;
            this.animal = null;
            MAJSchedule(rdv, animal);
            this.BackColor = Color.FromArgb(251,239,218);
        }

        /// <summary>
        /// Updates the display element
        /// </summary>
        private void MAJSchedule(RendezVous rdv, Animal animal)
        {
            if (rdv != null && animal != null)
            {
                ClientLB.Text = "Client : " + rdv.Client.NomClient;
                AnimalLB.Text = "Animal : " + animal.NomEspece;
            }
            else
            {
                ClientLB.Text = "";
                AnimalLB.Text = "";
            }
        }

        /// <summary>
        /// Click on the Schedule. Shows a new form to add a new schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Schedule_Click(object sender, EventArgs e)
        {
            if (rdv != null && animal != null)
            {
                CalendarDetails cd = new CalendarDetails(rdv);
                cd.Show();
                MAJSchedule(rdv, animal);
            }
        }
    }
}
