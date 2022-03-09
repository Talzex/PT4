using System;
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

        public Cart() { InitializeComponent(); }

        public Cart(Salarie user) : base(user)
        {
            InitializeComponent();
            afficherProduit();
        }

        private void afficherProduit()
        {
            foreach (Produit produit in Utils.GetProduitsAll())
            {
                var elementCart = new ElementCart(produit);
                Panel_AllProducts.Controls.Add(elementCart);
            }
        }
    }
}
