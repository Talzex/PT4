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

        public Calendar() { InitializeComponent(); }

        public Calendar(Salarie user) : base(user)
        {
            InitializeComponent();
            this.currentDate = DateTime.Now;
            this.firstDayOfWeek = FirstDayOfWeek(currentDate);
            DisplayDates(firstDayOfWeek);
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
        }
    }
}
