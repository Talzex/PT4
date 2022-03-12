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

        public Stock()
        {
            InitializeComponent();
            test();
        }

        public Stock(Salarie user) : base(user)
        {
            InitializeComponent();
            LoadProducts();
            test();
            allProducts = null; // Liste de tous les produits
        }

        // Remove function
        private void test()
        {
            Produit produit = new Produit();
            produit.NomProduit = "Medoc";
            produit.PrixVenteClient = 15.0;
        }

        /// <summary>
        /// Loads the products into the panel
        /// </summary>
        private void LoadProducts()
        {
            for (int i = page * elementsPerPage; i < page * (elementsPerPage + 1); i++)
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

        }

        /// <summary>
        /// Increases the page number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
