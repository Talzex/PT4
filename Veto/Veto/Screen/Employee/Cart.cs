﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class Cart : Veto.ScreenEmployee
    {
        public Cart()
        {
            InitializeComponent();
            test();
        }

        private void test()
        {
            Produit produit = new Produit();
            produit.NomProduit = "Medoc";
            produit.PrixVenteClient = 15.0;
            var elementCart = new ElementCart(produit);
            Panel_AllProducts.Controls.Add(elementCart);
        }
    }
}
