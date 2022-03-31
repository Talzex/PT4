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
    public partial class StockElement : UserControl
    {
        Produit product;

        public StockElement(Produit product)
        {
            InitializeComponent();
            this.product = product;
            MAJProduit(product);
        }

        /// <summary>
        /// Updates the display element
        /// </summary>
        public void MAJProduit(Produit product)
        {
            label_nom.Text = product.NomProduit;
            label_quantite.Text = "Quantité : " + product.QuantiteEnStock;
            label_pricesell.Text = "Prix de vente : " + product.PrixVenteClient + " €";
            label_purchaseprice.Text = "Prix d'achat : " + product.PrixAchat + " €";
            if(product.ImageProduit != null)
            {
                ImageProductPBOX.Image = Utils.ByteToImage(product.ImageProduit);
            }
            
        }

        /// <summary>
        /// Method to modify a product thanks to the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModify_Click(object sender, EventArgs e)
        {
            StockAjout stockAjout = new StockAjout(product);
            stockAjout.Show();
            this.Parent.Refresh();
            Refresh();
            
        }

        /// <summary>
        /// Method to delete a product from DataBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
