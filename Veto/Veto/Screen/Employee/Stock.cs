using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class Stock : Veto.ScreenEmployee
    {

        public Stock(Salarie user) : base(user)
        {
            InitializeComponent();
            showProduct();
        }

        /// <summary>
        /// Method to open the form to add a product in the stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductBTN_Click(object sender, EventArgs e)
        {
            StockAjout stockAjout = new StockAjout(null);
            if(stockAjout.ShowDialog() == DialogResult.Yes)
            {
                showProduct();
            }
           
        }

        /// <summary>
        /// Method to show all products without filter
        /// </summary>
        private void showProduct()
        {
            panel_Allproducts.Controls.Clear();
            foreach (Produit produit in Utils.GetProduitsAll())
            {
                var stockElement = new StockElement(produit);
                panel_Allproducts.Controls.Add(stockElement);
            }
        }

        /// <summary>
        /// Method to show products with a filter name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxResearch_TextChanged(object sender, EventArgs e)
        {
            panel_Allproducts.Controls.Clear();
            foreach (Produit produit in Utils.SearchProduct(textBoxResearch.Text))
            {
                var stockElement = new StockElement(produit);
                panel_Allproducts.Controls.Add(stockElement);
            }
        }

        /// <summary>
        /// Method to show products with filter in combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           int comboBoxIndex = comboBoxFilter.SelectedIndex;
            panel_Allproducts.Controls.Clear();
            switch (comboBoxIndex)
            {
                case 0:
                    foreach (Produit produit in Utils.QuantityProductDESC())
                    {
                        var stockElement = new StockElement(produit);
                        panel_Allproducts.Controls.Add(stockElement);
                    }
                    break;
                case 1:
                    foreach (Produit produit in Utils.QuantityProductASC())
                    {
                        var stockElement = new StockElement(produit);
                        panel_Allproducts.Controls.Add(stockElement);
                    }
                    break;
                case 2:
                    foreach (Produit produit in Utils.NameProductASC())
                    {
                        var stockElement = new StockElement(produit);
                        panel_Allproducts.Controls.Add(stockElement);
                    }
                    break;
                case 3:
                    foreach (Produit produit in Utils.NameProductDESC())
                    {
                        var stockElement = new StockElement(produit);
                        panel_Allproducts.Controls.Add(stockElement);
                    }
                    break;
            }
        }

        private void PreviousBTN_Click(object sender, EventArgs e)
        {

        }

        private void NextBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
