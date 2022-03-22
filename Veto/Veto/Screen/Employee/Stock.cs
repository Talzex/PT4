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
            stockAjout.Show();
        }

        /// <summary>
        /// Method to show all products without filter
        /// </summary>
        private void showProduct()
        {
            foreach (Produit produit in Utils.GetProduitsAll())
            {
                var stockElement = new StockElement(produit);
                all_productsPanel.Controls.Add(stockElement);
            }
        }

        /// <summary>
        /// Method to show products with a filter name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxResearch_TextChanged(object sender, EventArgs e)
        {
            all_productsPanel.Controls.Clear();
            foreach (Produit produit in Utils.SearchProduct(textBoxResearch.Text))
            {
                var stockElement = new StockElement(produit);
                all_productsPanel.Controls.Add(stockElement);
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
            all_productsPanel.Controls.Clear();
            switch (comboBoxIndex)
            {
                case 0:
                    foreach (Produit produit in Utils.QuantityProductDESC())
                    {
                        var stockElement = new StockElement(produit);
                        all_productsPanel.Controls.Add(stockElement);
                    }
                    break;
                case 1:
                    foreach (Produit produit in Utils.QuantityProductASC())
                    {
                        var stockElement = new StockElement(produit);
                        all_productsPanel.Controls.Add(stockElement);
                    }
                    break;
                case 2:
                    foreach (Produit produit in Utils.NameProductASC())
                    {
                        var stockElement = new StockElement(produit);
                        all_productsPanel.Controls.Add(stockElement);
                    }
                    break;
                case 3:
                    foreach (Produit produit in Utils.NameProductDESC())
                    {
                        var stockElement = new StockElement(produit);
                        all_productsPanel.Controls.Add(stockElement);
                    }
                    break;
            }
        }
    }
}
