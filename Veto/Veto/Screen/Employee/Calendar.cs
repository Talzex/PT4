using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class Calendar : Veto.ScreenEmployee
    {
        private DateTime currentDate;
        private DateTime firstDayOfWeek;

        private List<RendezVous> rendezVous;

        public Calendar() { InitializeComponent(); }

        public Calendar(Salarie user) : base(user)
        {
            InitializeComponent();
            this.currentDate = DateTime.Now;
            this.firstDayOfWeek = FirstDayOfWeek(currentDate);
            rendezVous = new List<RendezVous>();
            DisplayDates(firstDayOfWeek);
            DisplayRDV();
        }

        /// <summary>
        /// Return the first day of the week with the current day
        /// </summary>
        /// <param name="now">The current day</param>
        /// <returns>DateTime of the first day of the week</returns>
        private DateTime FirstDayOfWeek(DateTime now)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = now.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;

            if(diff < 0)
            {
                diff += 7;
            }
            return now.AddDays(-diff).Date;
        }

        /// <summary>
        /// Display all the dates in the screen
        /// </summary>
        /// <param name="firstDay">The first day of the week</param>
        private void DisplayDates(DateTime firstDay)
        {
            this.WeekLB.Text = "Semaine du " + this.firstDayOfWeek.ToString("dd/MM/yyyy");
            this.MondayLB.Text = "Lundi " + firstDay.ToString("dd");
            this.TuesdayLB.Text = "Mardi " + firstDay.AddDays(1).ToString("dd");
            this.WednesdayLB.Text = "Mercredi " + firstDay.AddDays(2).ToString("dd");
            this.ThursdayLB.Text = "Jeudi " + firstDay.AddDays(3).ToString("dd");
            this.FridayLB.Text = "Vendredi " + firstDay.AddDays(4).ToString("dd");
        }

        /// <summary>
        /// Display the next week
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextBT_Click(object sender, EventArgs e)
        {
            this.firstDayOfWeek = this.firstDayOfWeek.AddDays(7);
            DisplayDates(this.firstDayOfWeek);
            DisplayRDV();
        }

        /// <summary>
        /// Display the previous week
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevBT_Click(object sender, EventArgs e)
        {
            this.firstDayOfWeek = this.firstDayOfWeek.AddDays(-7);
            DisplayDates(this.firstDayOfWeek);
            DisplayRDV();
        }

        /// <summary>
        /// Display the window to add an appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRdvBT_Click(object sender, EventArgs e)
        {
            CalendarDetails calendar = new CalendarDetails();
            calendar.Show();
            if (DialogResult == DialogResult.OK)
            {
                DisplayRDV();
            }
        }

        /// <summary>
        /// Every time the form is shown on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calendar_Activated(object sender, EventArgs e)
        {
            DisplayRDV();
        }

        /// <summary>
        /// Displays the products in the cart
        /// </summary>
        private void DisplayRDV()
        {
            Schedule element = null;
            rendezVous = Utils.WeeklyRDV(firstDayOfWeek);
            int nb = rendezVous.Count;
            int total = 0;
            bool trouve = false;
            RDVLYT.Controls.Clear();

                for (int i = 9; i < 18; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (!(nb == total))
                        {

                            foreach (RendezVous rdv in rendezVous)
                            {
                               

                                    TimeSpan time = new TimeSpan(j, 0, 0, 0);
                                    if ((rdv.heureDebut.Hours <= i && rdv.heureFin.Hours > i) && firstDayOfWeek.Add(time).Day == rdv.Journee.Date.Day)
                                    {
                                        element = new Schedule(rdv, Utils.getAnimalRDV(rdv).Animal);
                                        total++;
                                        trouve = true;
                                    }

                                   
                                
                            }

                            if(!trouve)
                            {
                                element = new Schedule();
                            }
                            RDVLYT.Controls.Add(element);
                            trouve = false;
                        }
                    }
                }

        }
    }
}
