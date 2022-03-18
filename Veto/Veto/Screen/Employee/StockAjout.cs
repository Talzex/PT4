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
        public StockAjout()
        {
            InitializeComponent();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddimageBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Title = "Sélectionner une image";
            OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = new Bitmap(OpenFileDialog.FileName);
            }
            
        }

        private void ConfirmProductBTN_Click(object sender, EventArgs e)
        {
            AddProducts();
            this.Close();
        }

        /// <summary>
        /// Method to add a product to the stock
        /// </summary>
        private void AddProducts()
        {
            if (!NameProduct.Text.Trim().Equals("") && !QuantityProduct.Text.Trim().Equals("") &&
               !PurchasePriceProduct.Text.Trim().Equals("") && !SellPriceProduct.Text.Trim().Equals("") &&
               PictureBox.Image != null)
            {
                Produit produit = new Produit();

                produit.NomProduit = NameProduct.Text;
                produit.QuantiteEnStock = Int32.Parse(QuantityProduct.Text);
                produit.PrixAchat = double.Parse(PurchasePriceProduct.Text);
                produit.PrixVenteClient = double.Parse(SellPriceProduct.Text);
                produit.ImageProduit = Utils.ImageToByte(PictureBox.Image);

                Utils.SaveProduct(produit);
                Console.WriteLine("Insertion FAITE");

            }
        }



        private void QuantityProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SellPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void PurchasePriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');
        }

        private void NameProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
