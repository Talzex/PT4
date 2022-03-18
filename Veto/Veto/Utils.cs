﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    public static class Utils
    {
        private static Entities entities;

        public static void ChargerEntities()
        {
            entities = new Entities();
        }
        
        public static List<Client> GetClientsAll()
        {
            var clients = (from data in entities.Client
                          select data).ToList();

            return (List<Client>) clients;
        }
        

        public static Salarie GetSalarie(String login, String password)
        {
            var salarieQuerry = (from data in entities.Salarie
                                 where login == data.Login
                                 && password == data.MDP
                                 select data).FirstOrDefault();

            return (Salarie) salarieQuerry;
        }
    
        public static List<Roles> GetRolesAll()
        {
            var roles = (from data in entities.Roles
                        select data).ToList();

            return (List<Roles>) roles;
        }

        public static List<Produit> GetProduitsAll()
        {
            var produits = (from data in entities.Produit
                           select data).ToList();

            return (List<Produit>) produits;
        }

        public static void SaveClient(Client client)
        {
            entities.Client.Add(client);
            entities.SaveChanges();
        }

        public static void RemoveClient(Client client)
        {
            entities.Client.Remove(client);
            entities.SaveChanges();
        }
    }
}
