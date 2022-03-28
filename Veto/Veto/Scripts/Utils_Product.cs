using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veto
{
    public static partial class Utils
    {
        /// <summary>
        /// Query which return all the products
        /// </summary>
        /// <returns>All the products</returns>
        public static List<Produit> GetProductsAll()
        {
            var products = (from data in entities.Produit
                            select data).ToList();

            return (List<Produit>)products;
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
    }
}
