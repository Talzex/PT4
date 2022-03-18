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
    public partial class StockElement : UserControl
    {
        Produit product;

        public StockElement(Produit product)
        {
            InitializeComponent();
            this.product = product;
            UpdateDisplay();
        }

        /// <summary>
        /// Updates the display element
        /// </summary>
        private void UpdateDisplay()
        {
            label_nom.Text = product.NomProduit;
            label_quantite.Text = "Quantité : " + product.QuantiteEnStock;
            label_pricesell.Text = "Prix de vente : " + product.PrixVenteClient + " €";
            label_purchaseprice.Text = "Prix d'achat : " + product.PrixAchat + " €";
        }

        /// <summary>
        /// Click on the Product's image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormController.AddItemToCart(product,1);
        }
    }
}
