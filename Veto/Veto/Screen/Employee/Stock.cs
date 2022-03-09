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

        public Stock() { InitializeComponent(); }

        public Stock(Salarie user) : base(user)
        {
            InitializeComponent();
            test();
        }

        private void test()
        {
            Produit produit = new Produit();
            produit.NomProduit = "Medoc";
            produit.PrixVenteClient = 15.0;
            var stockElement = new StockElement(produit);
            panel_Allproducts.Controls.Add(stockElement);
        }
    }
}
