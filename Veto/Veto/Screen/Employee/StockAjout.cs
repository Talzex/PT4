using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    public partial class StockAjout : Form
    {
        Produit product = new Produit();
        public StockAjout(Produit produit)
        {
            InitializeComponent();
            if (produit != null)
            {
                NameProduct.Text = produit.NomProduit;
                QuantityProduct.Text = produit.QuantiteEnStock.ToString();
                PurchasePriceProduct.Text = produit.PrixAchat.ToString();
                SellPriceProduct.Text = produit.PrixVenteClient.ToString();
                if (produit.ImageProduit != null)
                {
                    PictureBox.Image = Utils.ByteToImage(produit.ImageProduit);
                }
            }
            product = produit;

        }

        /// <summary>
        /// Method to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method to add image link with the product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddimageBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Title = "Sélectionner une image";
            OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = new Bitmap(OpenFileDialog.FileName);
            }

        }

        /// <summary>
        /// Method to update the product in the DataBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmProductBTN_Click(object sender, EventArgs e)
        {
            Produit Newproduit = null;
            String message = "";
            String caption = "";


            if (!String.IsNullOrEmpty(NameProduct.Text) && !String.IsNullOrEmpty(QuantityProduct.Text) && !String.IsNullOrEmpty(PurchasePriceProduct.Text)
                && !String.IsNullOrEmpty(SellPriceProduct.Text))
            {
                Newproduit = AddModifyProducts();
            }
            else
            {
                message = "Tous les champs ne sont pas remplis";
                caption = "Erreur du formulaire d'ajout/modification";
                var messageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            if (Newproduit != null)
            {
                if (SameProducts(Newproduit))
                {
                    message = "Vous ne pouvez pas utiliser ce nom, il est déjà utilisé";
                    caption = "Erreur du nom du produit";
                    var messageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK);

                }

                else if (Price(Newproduit))
                {
                    message = "Le prix d'achat doit être inférieur ou égal au prix de vente";
                    caption = "Erreur du prix produit";
                    var messageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                else if (ZeroPrice(Newproduit))
                {
                    message = "Le prix d'achat ou le prix de vente, ne peuvent pas être égal à zéro";
                    caption = "Erreur valeur prix du produit";
                    var messageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                else
                {
                    if (product != null)
                    {
                        Utils.ModifyProduct(Newproduit, Newproduit.NomProduit,
                        Newproduit.QuantiteEnStock, Newproduit.ImageProduit,
                        Newproduit.PrixVenteClient, Newproduit.PrixAchat);
                    }
                    else
                    {
                        Utils.SaveProduct(AddModifyProducts());
                    }
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Method to add or modify the product to the stock
        /// </summary>
        private Produit AddModifyProducts()
        {
            Produit produit = null;
            if (product == null)
            {
                produit = new Produit(); // Add
            }
            else
            {
                produit = product; // Modify
            }

            produit.NomProduit = NameProduct.Text;
            produit.QuantiteEnStock = Int32.Parse(QuantityProduct.Text);
            produit.PrixAchat = double.Parse(PurchasePriceProduct.Text);
            produit.PrixVenteClient = double.Parse(SellPriceProduct.Text);
            if (produit.ImageProduit != null)
            {
                produit.ImageProduit = Utils.ImageToByte(PictureBox.Image);
            }
            return produit;
        }

        /// <summary>
        /// Method to verify if there is a product with the same name in the DB
        /// </summary>
        /// <param name="NewProduit">The product to verify</param>
        /// <returns>ReturnS true if there is the same name, no otherwise</returns>
        private Boolean SameProducts(Produit NewProduit)
        {
            Boolean identique = false;
            foreach (Produit produit in Utils.GetProductsAll())
            {
                if (product != null)
                {
                    if (produit.NomProduit.Equals(NewProduit.NomProduit) && !produit.NomProduit.Equals(product.NomProduit))
                    {
                        identique = true;
                    }
                }
                else
                {
                    if (produit.NomProduit.Equals(NewProduit.NomProduit))
                    {
                        identique = true;
                    }
                }
            }
            return identique;
        }

        /// <summary>
        /// Method to verify that the price sell is higher than purchase price
        /// </summary>
        /// <param name="NewProduit">The product to verify</param>
        /// <returns>Returns true if it is not respected, false otherwise</returns>
        private Boolean Price(Produit NewProduit)
        {
            return NewProduit.PrixVenteClient <= NewProduit.PrixAchat;
        }

        private Boolean ZeroPrice(Produit NewProduit)
        {
            return ((SellPriceProduct.Text.StartsWith("0") && !SellPriceProduct.Text.Contains(",")) ||
                (PurchasePriceProduct.Text.StartsWith("0") && !SellPriceProduct.Text.Contains(",")));
        }

        /// <summary>
        /// Method to reduce key possibilities, in that case only number 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuantityProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Method to reduce key possibilities, in that case only number with decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        /// <summary>
        /// Method to reduce key possibilities, in that case only number with decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PurchasePriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        /// <summary>
        /// Method to reduce key possibilities, in that case only letter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
