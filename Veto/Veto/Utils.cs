using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    /// <summary>
    /// Class with all the queries of the project
    /// </summary>
    public static partial class Utils
    {
        private static Entities entities;

        /// <summary>
        /// Initialize the instance of the BD's entity
        /// </summary>
        public static void LoadEntities()
        {
            entities = new Entities();
        }

        /// <summary>
        /// Query which return the product with the filter "Name DESC"
        /// </summary>
        /// <returns>the products</returns>
        public static List<Produit> NameProductDESC()
        {
            var produits = (from data in entities.Produit
                            orderby data.NomProduit descending
                            select data).ToList();

            return (List<Produit>)produits;
        }

        /// <summary>
        /// Query which modify a client
        /// </summary>
        /// <param name="client">the client</param>
        /// <param name="nomClient">his name</param>
        /// <param name="prenomClient">his surname</param>
        /// <param name="dateDeNaissance">his birth date</param>
        /// <param name="numeroTelephone">his phone number</param>
        /// <param name="adresseMail">his mail</param>
        public static void ModifyClient(Client client, String nomClient, String prenomClient, DateTime dateDeNaissance, String numeroTelephone, String adresseMail)
        {
            if (client != null)
            {
                client.NomClient = nomClient;
                client.PrenomClient = prenomClient;
                client.DateNaissance = dateDeNaissance;
                client.NumeroTelephone = numeroTelephone;
                client.AdresseMail = adresseMail;
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which modify a RDV
        /// </summary>
        /// <param name="rendezVous">the rdv</param>
        /// <param name="idClient">the client</param>
        /// <param name="animal">the animal</param>
        /// <param name="heureDebut">begin of the rdv</param>
        /// <param name="heureFin">end of the rdv</param>
        /// <param name="motif">the cause</param>
        /// <param name="idJournee">the day of the rdv</param>
        public static void ModifyRDV(RendezVous rendezVous, int idClient, Animal animal, TimeSpan heureDebut, TimeSpan heureFin, String motif, int idJournee)
        {
            if (rendezVous != null)
            {
                rendezVous.IdClient = idClient;
                rendezVous.AnimalRDV = (ICollection<AnimalRDV>)animal;
                rendezVous.heureDebut = heureDebut;
                rendezVous.heureFin = heureFin;
                rendezVous.motif = motif;
                rendezVous.IdJournee = idJournee;
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which add a day to the BD
        /// </summary>
        /// <param name="journee">the day</param>
        public static void SaveDay(Journee journee)
        {
            if (journee != null)
            {
                entities.Journee.Add(journee);
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

    }
}
