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
        Produit product = new Produit();
        public StockElement(Produit product)
        {
            InitializeComponent();
            this.product = product;
            MAJProduit(product);
        }

        private void MAJProduit(Produit product)
        {
            label_nom.Text = product.NomProduit;
            label_quantite.Text = "Quantité : " + product.QuantiteEnStock;
            label_pricesell.Text = "Prix de vente : " + product.PrixVenteClient + " €";
            label_purchaseprice.Text = "Prix d'achat : " + product.PrixAchat + " €";
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            StockAjout stockAjout = new StockAjout(product);
            stockAjout.Show();
            MAJProduit(product);
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            String message = "Êtes vous sûr de vouloir le supprimer";
            String caption = "Suppression Produits";
            var messageBox =  MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            if(messageBox == DialogResult.Yes)
            {
                Parent.Controls.Remove(this);
                Utils.RemoveProduct(product);
            }
            
        }
    }
}
