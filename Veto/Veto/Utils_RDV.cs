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
        /// Query which add a RDV to the BD
        /// </summary>
        /// <param name="rdv">the RDV</param>
        public static void SaveRDV(RendezVous rdv)
        {
            if (rdv != null)
            {
                entities.RendezVous.Add(rdv);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which remove a RDV from the BD
        /// </summary>
        /// <param name="rdv">the RDV</param>
        public static void RemoveRDV(RendezVous rdv)
        {
            if (rdv != null)
            {
                entities.RendezVous.Remove(rdv);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which return all the RDV of the week
        /// </summary>
        /// <param name="monday">date of the beginn of the current week</param>
        /// /// <returns>the list of rdv</returns>
        public static List<RendezVous> WeeklyRDV(TimeSpan monday)
        {
            System.TimeSpan week = new System.TimeSpan(7, 0, 0, 0);
            var rdv = (from data in entities.RendezVous
                       where data.heureDebut >= monday && data.heureFin < monday.Add(week)
                       select data).ToList();

            return (List<RendezVous>)rdv;
        }
    }
}
