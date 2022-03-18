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
    public static class Utils
    {
        private static Entities entities;

        /// <summary>
        /// Initialize the instance of the BD's entity
        /// </summary>
        public static void ChargerEntities()
        {
            entities = new Entities();
        }
        
        /// <summary>
        /// Query which return all the clients
        /// </summary>
        /// <returns>All the clients</returns>
        public static List<Client> GetClientsAll()
        {
            var clients = (from data in entities.Client
                          select data).ToList();

            return (List<Client>) clients;
        }
        
        /// <summary>
        /// Query which get a employee
        /// </summary>
        /// <param name="login">Employee's login</param>
        /// <param name="password">Employee's password</param>
        /// <returns>The employee</returns>
        public static Salarie GetSalarie(String login, String password)
        {
            var salarieQuerry = (from data in entities.Salarie
                                 where login == data.Login
                                 && password == data.MDP
                                 select data).FirstOrDefault();

            return (Salarie) salarieQuerry;
        }
    
        /// <summary>
        /// Query which return all the roles
        /// </summary>
        /// <returns>All the roles</returns>
        public static List<Roles> GetRolesAll()
        {
            var roles = (from data in entities.Roles
                        select data).ToList();

            return (List<Roles>) roles;
        }

        /// <summary>
        /// Query which return all the products
        /// </summary>
        /// <returns>All the products</returns>
        public static List<Produit> GetProduitsAll()
        {
            var produits = (from data in entities.Produit
                           select data).ToList();

            return (List<Produit>) produits;
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
                entities.Client.Remove(client);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which add a product to the BD
        /// </summary>
        /// <param name="produit">the product</param>
        public static void SaveProduct(Produit produit)
        {
            if (produit != null)
            {
                entities.Produit.Add(produit);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which remove a product from the BD
        /// </summary>
        /// <param name="produit">the product</param>
        public static void RemoveProduct(Produit produit)
        {
            if (produit != null)
            {
                entities.Produit.Remove(produit);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which modify a product
        /// </summary>
        /// <param name="produit">the product</param>
        /// <param name="nomProduit">the product's name</param>
        /// <param name="quantite"></param>
        /// <param name="image">the product's image</param>
        /// <param name="prixVente">Selling price</param>
        /// <param name="prixAchat">purchase price</param>
        public static void ModifyProduct(Produit produit, String nomProduit, int quantite, Bitmap image, float prixVente, float prixAchat)
        {
            if (produit != null)
            {
                produit.NomProduit = nomProduit;
                produit.QuantiteEnStock = quantite;
                produit.ImageProduit = ImageToByte(image);
                produit.PrixVenteClient = prixVente;
                produit.PrixAchat = prixAchat;
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Convert a bitmap into a byte[]
        /// </summary>
        /// <param name="img">the bitmap</param>
        /// <returns>the byte[]</returns>
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        /// <summary>
        /// Query which return products thanks to a search
        /// </summary>
        /// <param name="product">the search</param>
        /// <returns>the products</returns>
        public static List<Produit> SearchProduct(String product)
        {
            var produits = (from data in entities.Produit
                            where data.NomProduit.Contains(product)
                            select data).ToList();

            return (List<Produit>)produits;
        }

        /// <summary>
        /// Query which return the product with the filter "Quantity ASC"
        /// </summary>
        /// <returns>the products</returns>
        public static List<Produit> QuantityProductASC()
        {
            var produits = (from data in entities.Produit
                            orderby data.QuantiteEnStock ascending
                            select data).ToList();

            return (List<Produit>)produits;
        }

        /// <summary>
        /// Query which return the product with the filter "Quantity DESC"
        /// </summary>
        /// <returns>the products</returns>
        public static List<Produit> QuantityProductDESC()
        {
            var produits = (from data in entities.Produit
                            orderby data.QuantiteEnStock descending
                            select data).ToList();

            return (List<Produit>)produits;
        }

        /// <summary>
        /// Query which return the product with the filter "Name ASC"
        /// </summary>
        /// <returns>the products</returns>
        public static List<Produit> NameProductASC()
        {
            var produits = (from data in entities.Produit
                            orderby data.NomProduit ascending
                            select data).ToList();

            return (List<Produit>)produits;
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
    }
}
