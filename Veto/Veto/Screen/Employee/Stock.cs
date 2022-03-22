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
        }

        public Stock(Salarie user) : base(user)
        {
            InitializeComponent();
            allProducts = Utils.GetProduitsAll();
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
