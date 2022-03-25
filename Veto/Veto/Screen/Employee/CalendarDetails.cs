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
        public CalendarDetails()
        {
            InitializeComponent();
        }

        public CalendarDetails(RendezVous rdv)
        {
            InitializeComponent();
            this.ClientsList.SelectedItem = rdv.Client;
            this.AnimalsList.SelectedItem = rdv.AnimalRDV;
            this.BeginHour.Value = rdv.heureDebut.Hours;
            this.EndHour.Value = rdv.heureFin.Hours;
            this.Date.SelectionRange.Start = rdv.Journee.Date;
        }
    }
}
