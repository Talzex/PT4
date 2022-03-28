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
            if(produit != null)
            {
                NameProduct.Text = produit.NomProduit;
                QuantityProduct.Text = produit.QuantiteEnStock.ToString();
                PurchasePriceProduct.Text = produit.PrixAchat.ToString();
                SellPriceProduct.Text = produit.PrixVenteClient.ToString();
            }
            this.product = produit;
            
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
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
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
            
            if (!String.IsNullOrEmpty(NameProduct.Text) && !String.IsNullOrEmpty(QuantityProduct.Text) && !String.IsNullOrEmpty(PurchasePriceProduct.Text)
                && !String.IsNullOrEmpty(SellPriceProduct.Text) && PictureBox.Image != null)
            {
                Newproduit = AddProducts();
            } else
            {
                String message = "Tout les champs ne sont pas remplis";
                String caption = "Erreur du formulaire d'ajout/modification";
                var messageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            if(Newproduit != null)
            {
                if (SameProducts(Newproduit))
                {
                    String message = "Vous ne pouvez pas utiliser ce nom, il est déjà utilisé";
                    String caption = "Erreur du nom du produit";
                    var messageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK);

                } else if (Price(Newproduit)){
                    String message = "Le prix d'achat doit être inférieur ou égal au prix de vente";
                    String caption = "Erreur du prix produit";
                    var messageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                else
                {
                    Utils.SaveProduct(AddProducts());
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Method to add or modify the product to the stock
        /// </summary>
        private Produit AddProducts()
        {
            Produit produit = new Produit();
            produit.NomProduit = NameProduct.Text;
            produit.QuantiteEnStock = Int32.Parse(QuantityProduct.Text);
            produit.PrixAchat = double.Parse(PurchasePriceProduct.Text);
            produit.PrixVenteClient = double.Parse(SellPriceProduct.Text);
            produit.ImageProduit = Utils.ImageToByte(PictureBox.Image);
            return produit;
        }

        /// <summary>
        /// Method to verify if there is a product with the same name in the DataBase
        /// </summary>
        /// <param name="NewProduit">The product to verify</param>
        /// <returns>Returns true if there is the same name, no otherwise</returns>
        private Boolean SameProducts(Produit NewProduit)
        {
            Boolean identique = false;
            foreach (Produit produit in Utils.GetProductsAll())
            {
                if (produit.NomProduit.Equals(NewProduit.NomProduit))
                {
                    identique = true;
                }
            }
            return identique;
        }

        private Boolean Price(Produit NewProduit)
        {
            return NewProduit.PrixVenteClient <= NewProduit.PrixAchat;
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
