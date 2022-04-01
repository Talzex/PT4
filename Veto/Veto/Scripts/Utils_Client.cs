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
        /// Query which return all the clients
        /// </summary>
        /// <returns>All the clients</returns>
        public static List<Client> GetClientsAll()
        {
            var clients = (from data in entities.Client
                           orderby data.NomClient, data.PrenomClient ascending
                           select data).ToList();

            return (List<Client>)clients;
        }

        /// <summary>
        /// Query which add a client to the BD
        /// </summary>
        /// <param name="client">the client</param>
        public static void SaveClient(Client client)
        {
            if (client != null)
            {
                entities.Client.Add(client);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which remove a client from the BD
        /// </summary>
        /// <param name="client">the client</param>
        public static void RemoveClient(Client client)
        {
            if (client != null)
            {
                foreach (RendezVous rdv in Utils.GetClientsRDV(client))
                {
                    Utils.RemoveRDV(rdv);
                }
                foreach (Animal a in Utils.getClientAnimals(client))
                {
                    Utils.RemoveAnimal(a);
                }
                entities.Client.Remove(client);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which return all the animals of a client
        /// </summary>
        /// <param name="client">the client</param>
        /// <returns>the animals</returns>
        public static List<Animal> ClientAnimals(Client client)
        {
            var animals = (from data in entities.Animal
                           where data.IdClient == client.IdClient
                           select data).ToList();
            return (List<Animal>)animals;
        }

        /// <summary>
        /// Query which modify a client
        /// </summary>
        /// <param name="client">the client</param>
        /// <param name="nameClient">his name</param>
        /// <param name="firstNameClient">his surname</param>
        /// <param name="birthDate">his birth date</param>
        /// <param name="phoneNumber">his phone number</param>
        /// <param name="mail">his mail</param>
        public static void ModifyClient(Client client, String nameClient, String firstNameClient, DateTime birthDate, String phoneNumber, String mail)
        {
            if (client != null)
            {
                client.NomClient = nameClient;
                client.PrenomClient = firstNameClient;
                client.DateNaissance = birthDate;
                client.NumeroTelephone = phoneNumber;
                client.AdresseMail = mail;
                entities.SaveChanges();
            }
        }
    }
}
