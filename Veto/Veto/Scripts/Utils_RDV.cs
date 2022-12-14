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
                AnimalRDV[] ard = rdv.AnimalRDV.ToArray();
                for (int i = 0; i < ard.Length; i++)
                {
                    entities.AnimalRDV.Remove(ard[i]);
                }
                entities.RendezVous.Remove(rdv);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which return all the RDV of the week
        /// </summary>
        /// <param name="monday">date of the beginn of the current week</param>
        /// /// <returns>the list of rdv</returns>
        public static List<RendezVous> WeeklyRDV(DateTime monday)
        {
            System.TimeSpan week = new System.TimeSpan(7, 0, 0, 0);
            DateTime sunday = monday.Add(week);
            var rdv = (from data in entities.RendezVous
                       where data.Journee.Date >= monday && data.Journee.Date < sunday
                       orderby data.heureDebut ascending
                       select data).ToList();

            return (List<RendezVous>)rdv;
        }

        /// <summary>
        /// Query which modify a RDV
        /// </summary>
        /// <param name="rendezVous">the rdv</param>
        /// <param name="idClient">the client</param>
        /// <param name="animal">the animal</param>
        /// <param name="begin">begin of the rdv</param>
        /// <param name="end">end of the rdv</param>
        /// <param name="cause">the cause</param>
        /// <param name="idDay">the day of the rdv</param>
        public static void ModifyRDV(RendezVous rendezVous, int idClient, TimeSpan begin, TimeSpan end, String cause, int idDay)
        {
            if (rendezVous != null)
            {
                rendezVous.IdClient = idClient;
                rendezVous.heureDebut = begin;
                rendezVous.heureFin = end;
                rendezVous.motif = cause;
                rendezVous.IdJournee = idDay;
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which return the animal of the rdv
        /// </summary>
        /// <param name="rdv">the rdv</param>
        /// <returns>the animal</returns>
        public static AnimalRDV getAnimalRDV(RendezVous rdv)
        {
            var animal = (from data in entities.AnimalRDV
                          where data.IdRDV == rdv.idRdv
                          select data).First();

            return (AnimalRDV)animal;
        }

        /// <summary>
        /// Query which return all the RDV
        /// </summary>
        /// /// <returns>the list of rdv</returns>
        public static List<RendezVous> getAllRDV()
        {
            var rdv = (from data in entities.RendezVous
                       select data).ToList();

            return (List<RendezVous>)rdv;
        }

        /// <summary>
        /// Gets all appointments for a client
        /// </summary>
        /// <param name="c">The Client</param>
        /// <returns>The Clients appointments</returns>
        public static List<RendezVous> GetClientsRDV(Client c)
        {
            var rdv = (from data in entities.RendezVous
                       where data.IdClient == c.IdClient
                       select data).ToList();

            return (List<RendezVous>)rdv;
        }
    }
}
