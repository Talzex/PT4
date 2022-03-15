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

        private Dictionary<Produit, int> cart;

        public Cart() { InitializeComponent(); }

        public Cart(Salarie user) : base(user)
        {
            InitializeComponent();
            cart = new Dictionary<Produit, int>();
        }

        /// <summary>
        /// Displays the products in the cart
        /// </summary>
        private void AfficherProduit()
        {
            foreach (Produit product in cart.Keys)
            {
                int nb; cart.TryGetValue(product, out nb);
                var elementCart = new ElementCart(product, nb);
                Panel_AllProducts.Controls.Add(elementCart);
            }
        }

        /// <summary>
        /// Every time the form is shown on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cart_Activated(object sender, EventArgs e)
        {
            AfficherProduit();
        }

        public void AddProduct(Produit p, int nb)
        {
            if (!cart.ContainsKey(p))
            {
                cart.Add(p, nb);
            }
            else
            {
                cart[p] += nb;
            }
        }
    }
}
