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
        private readonly int elementsPerPage = 6;
        private List<Produit> allProducts;

        public Stock(Salarie user) : base(user)
        {
            InitializeComponent();
            allProducts = Utils.GetProductsAll();
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
            foreach (Produit produit in Utils.GetProductsAll())
            {
                var stockElement = new StockElement(produit);
                panel_Allproducts.Controls.Add(stockElement);
            }
        }

        /// <summary>
        /// Loads the products into the panel
        /// </summary>
        private void LoadProducts()
        {
            for (int i = page * elementsPerPage; i < (page+1) * elementsPerPage; i++)
            {
                if (i < allProducts.Count)
                {
                    var stockElement = new StockElement(allProducts[i]);
                    panel_Allproducts.Controls.Add(stockElement);
                }
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

        /// Every time the form is shown on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stock_Activated(object sender, EventArgs e)
        {
            page = 0;
            PreviousBTN.Enabled = false;
            if (allProducts.Count <= elementsPerPage)
            {
                NextBTN.Enabled = false;
            }
            LoadProducts();
        }
    }
}
