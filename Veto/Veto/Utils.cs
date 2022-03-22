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
        public static void LoadEntities()
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
            var employeeQuerry = (from data in entities.Salarie
                                 where login == data.Login
                                 && password == data.MDP
                                 select data).FirstOrDefault();

            return (Salarie)employeeQuerry;
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
            var products = (from data in entities.Produit
                           select data).ToList();

            return (List<Produit>)products;
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
        /// <param name="product">the product</param>
        public static void SaveProduct(Produit product)
        {
            if (product != null)
            {
                entities.Produit.Add(product);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which remove a product from the BD
        /// </summary>
        /// <param name="product">the product</param>
        public static void RemoveProduct(Produit product)
        {
            if (product != null)
            {
                entities.Produit.Remove(product);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which modify a product
        /// </summary>
        /// <param name="product">the product</param>
        /// <param name="nameProduct">the product's name</param>
        /// <param name="quantity"></param>
        /// <param name="image">the product's image</param>
        /// <param name="salePrice">Selling price</param>
        /// <param name="purchasePrice">purchase price</param>
        public static void ModifyProduct(Produit product, String nameProduct, int quantity, Bitmap image, float salePrice, float purchasePrice)
        {
            if (product != null)
            {
                product.NomProduit = nameProduct;
                product.QuantiteEnStock = quantity;
                product.ImageProduit = ImageToByte(image);
                product.PrixVenteClient = salePrice;
                product.PrixAchat = purchasePrice;
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
        /// Convert a byte[] into a bitmap
        /// </summary>
        /// <param name="img">the byte[]</param>
        /// <returns>the bitmap</returns>
        public static Image ByteToImage(byte[] img)
        {
            ImageConverter converter = new ImageConverter();
            return (Image)converter.ConvertTo(img, typeof(Image));
        }

        /// <summary>
        /// Query which return products thanks to a search
        /// </summary>
        /// <param name="search">the search</param>
        /// <returns>the products</returns>
        public static List<Produit> SearchProduct(String search)
        {
            var products = (from data in entities.Produit
                            where data.NomProduit.Contains(search)
                            select data).ToList();

            return (List<Produit>)products;
        }

        /// <summary>
        /// Query which return the product with the filter "Quantity ASC"
        /// </summary>
        /// <returns>the products</returns>
        public static List<Produit> QuantityProductASC()
        {
            var products = (from data in entities.Produit
                            orderby data.QuantiteEnStock ascending
                            select data).ToList();

            return (List<Produit>)products;
        }

        /// <summary>
        /// Query which return the product with the filter "Quantity DESC"
        /// </summary>
        /// <returns>the products</returns>
        public static List<Produit> QuantityProductDESC()
        {
            var products = (from data in entities.Produit
                            orderby data.QuantiteEnStock descending
                            select data).ToList();

            return (List<Produit>)products;
        }

        /// <summary>
        /// Query which return the product with the filter "Name ASC"
        /// </summary>
        /// <returns>the products</returns>
        public static List<Produit> NameProductASC()
        {
            var products = (from data in entities.Produit
                            orderby data.NomProduit ascending
                            select data).ToList();

            return (List<Produit>)products;
        }

        /// <summary>
        /// Query which return the product with the filter "Name DESC"
        /// </summary>
        /// <returns>the products</returns>
        public static List<Produit> NameProductDESC()
        {
            var products = (from data in entities.Produit
                            orderby data.NomProduit descending
                            select data).ToList();

            return (List<Produit>)products;
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
        /// Query which remove a quantity of a product
        /// </summary>
        /// <param name="product">the product</param>
        /// <param name="quantity">the quantity</param>
        public static void RemoveQuantityProduct(Produit product, int quantity)
        {
            if (product != null)
            {
                if (product.QuantiteEnStock - quantity >= 0)
                {
                    product.QuantiteEnStock -= quantity;
                    entities.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Query which add a invoice to the BD
        /// </summary>
        /// <param name="invoice">the invoice</param>
        public static void SaveRDV(Facture invoice)
        {
            if (invoice != null)
            {
                entities.Facture.Add(invoice);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which add product invoices to the BD
        /// </summary>
        /// <param name="productInvoice">product invoices</param>
        public static void SaveProductInvoices(List<ProduitFacture> productInvoice) 
        {
            if (productInvoice != null)
            {
                foreach (ProduitFacture p in productInvoice)
                {
                    entities.ProduitFacture.Add(p);
                }
                entities.SaveChanges();
            }
        }
    }
}
