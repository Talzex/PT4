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
        private int page;
        private readonly int elementsPerPage = 8;
        private List<Produit> allProducts;

        public Stock(Salarie user) : base(user)
        {
            InitializeComponent();
            allProducts = Utils.GetProductsAll();
            ResetItems();
        }

        /// <summary>
        /// Method to open the form to add a product in the stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductBTN_Click(object sender, EventArgs e)
        {
            StockAjout stockAjout = new StockAjout(null);
            if (stockAjout.ShowDialog() == DialogResult.OK)
            {
                allProducts = Utils.GetProductsAll();
                LoadProducts();
            }

        }

        /// <summary>
        /// Loads the products into the panel
        /// </summary>
        private void LoadProducts()
        {
            AllProductsPNL.Controls.Clear();
            for (int i = page * elementsPerPage; i < (page + 1) * elementsPerPage && i < allProducts.Count; i++)
            {
                var stockElement = new StockElement(allProducts[i]);
                AllProductsPNL.Controls.Add(stockElement);
            }
        }

        /// <summary>
        /// Reduces the page number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousBTN_Click(object sender, EventArgs e)
        {
            page--;
            NextBTN.Enabled = true;
            if (page == 0)
            {
                PreviousBTN.Enabled = false;
            }
            LoadProducts();
        }

        /// <summary>
        /// Method to show products with a filter name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxResearch_TextChanged(object sender, EventArgs e)
        {
            AllProductsPNL.Controls.Clear();
            foreach (Produit produit in Utils.SearchProduct(TextBoxResearch.Text))
            {
                var stockElement = new StockElement(produit);
                AllProductsPNL.Controls.Add(stockElement);
            }
        }

        /// Increases the page number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextBTN_Click(object sender, EventArgs e)
        {
            page++;
            PreviousBTN.Enabled = true;
            if ((page + 1) * elementsPerPage >= allProducts.Count)
            {
                NextBTN.Enabled = false;
            }
            LoadProducts();
        }

        /// <summary>
        /// Method to show products with filter in combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboBoxIndex = FilterBox.SelectedIndex;
            AllProductsPNL.Controls.Clear();
            switch (comboBoxIndex)
            {
                case 0:
                    foreach (Produit produit in Utils.QuantityProductDESC())
                    {
                        var stockElement = new StockElement(produit);
                        AllProductsPNL.Controls.Add(stockElement);
                    }
                    break;
                case 1:
                    foreach (Produit produit in Utils.QuantityProductASC())
                    {
                        var stockElement = new StockElement(produit);
                        AllProductsPNL.Controls.Add(stockElement);
                    }
                    break;
                case 2:
                    foreach (Produit produit in Utils.NameProductASC())
                    {
                        var stockElement = new StockElement(produit);
                        AllProductsPNL.Controls.Add(stockElement);
                    }
                    break;
                case 3:
                    foreach (Produit produit in Utils.NameProductDESC())
                    {
                        var stockElement = new StockElement(produit);
                        AllProductsPNL.Controls.Add(stockElement);
                    }
                    break;
            }
        }

        /// Every time the form is shown on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stock_Activated(object sender, EventArgs e)
        {
            ResetItems();
        }

        private void ResetItems()
        {
            page = 0;
            PreviousBTN.Enabled = false;
            if (allProducts.Count < elementsPerPage)
            {
                NextBTN.Enabled = false;
            }
            LoadProducts();
        }
    }
}
