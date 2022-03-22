﻿using System;
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
        Produit product;
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
            Utils.SaveProduct(AddProducts());
            this.Close();
        }

        /// <summary>
        /// Method to add or modify the product to the stock
        /// </summary>
        private Produit AddProducts()
        {
            Produit produit = new Produit();
            if (!NameProduct.Text.Trim().Equals("") && !QuantityProduct.Text.Trim().Equals("") &&
               !PurchasePriceProduct.Text.Trim().Equals("") && !SellPriceProduct.Text.Trim().Equals("") &&
               PictureBox.Image != null)
            {
                
                produit.NomProduit = NameProduct.Text;
                produit.QuantiteEnStock = Int32.Parse(QuantityProduct.Text);
                produit.PrixAchat = double.Parse(PurchasePriceProduct.Text);
                produit.PrixVenteClient = double.Parse(SellPriceProduct.Text);
                produit.ImageProduit = Utils.ImageToByte(PictureBox.Image);
            }
            return produit;
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
