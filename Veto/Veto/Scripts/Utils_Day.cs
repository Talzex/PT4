using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veto
{
    public static partial class Utils
    {
        /// <summary>
        /// Query which add a day to the BD
        /// </summary>
        /// <param name="day">the day</param>
        public static void SaveDay(Journee day)
        {
            if (day != null)
            {
                entities.Journee.Add(day);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which get a day
        /// </summary>
        /// <param name="date">the date</param>
        /// <returns>The day</returns>
        public static Journee GetDay(DateTime date)
        {
            var dayQuerry = (from data in entities.Journee
                             where date == data.Date
                             select data).FirstOrDefault();

            return (Journee)dayQuerry;
        }
    }
}
