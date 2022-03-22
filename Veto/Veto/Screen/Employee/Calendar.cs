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

        private void DisplayDates(DateTime firstDay)
        {
            this.WeekLB.Text = "Semaine du " + this.firstDayOfWeek.ToString("dd/MM/yyyy");
            this.MondayLB.Text = "Lundi " + firstDay.ToString("dd");
            this.TuesdayLB.Text = "Mardi " + firstDay.AddDays(1).ToString("dd");
            this.WednesdayLB.Text = "Mercredi " + firstDay.AddDays(2).ToString("dd");
            this.ThursdayLB.Text = "Jeudi " + firstDay.AddDays(3).ToString("dd");
            this.FridayLB.Text = "Vendredi " + firstDay.AddDays(4).ToString("dd");
        }

        private void NextBT_Click(object sender, EventArgs e)
        {
            this.firstDayOfWeek = this.firstDayOfWeek.AddDays(7);
            Console.WriteLine(this.firstDayOfWeek);
            DisplayDates(this.firstDayOfWeek);
        }

        private void PrevBT_Click(object sender, EventArgs e)
        {
            this.firstDayOfWeek = this.firstDayOfWeek.AddDays(-7);
            Console.WriteLine(this.firstDayOfWeek);
            DisplayDates(this.firstDayOfWeek);
        }
    }
}
