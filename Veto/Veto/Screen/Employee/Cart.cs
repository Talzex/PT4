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
            Panel_AllProducts.Controls.Clear();
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

        /// <summary>
        /// Adds a product with a certain quantity to the cart (if it's possible)
        /// </summary>
        /// <param name="p">The product to add</param>
        /// <param name="nb">The quantity to add</param>
        /// <returns>The quantity in the cart</returns>
        public int AddProduct(Produit p, int nb)
        {

            if (!cart.ContainsKey(p))
            {
                if (nb <= 0) return 0;
                if (nb > p.QuantiteEnStock)
                {
                    nb = p.QuantiteEnStock;
                }
                cart.Add(p, nb);
                return nb;
            }
            else
            {
                if (nb > 0)
                {
                    if (nb + cart[p] > p.QuantiteEnStock)
                    {
                        nb = p.QuantiteEnStock - cart[p];
                    }
                    cart[p] += nb;
                }
                return cart[p];
            }
        }

        /// <summary>
        /// Removes a certain quantity of a product from the cart (if it's possible)
        /// </summary>
        /// <param name="p">The product to remove</param>
        /// <param name="nb">The quantity to remove</param>
        /// <returns>If the display should be removed (when the new quantity is under or equal to 0)</returns>
        public bool RemoveProduct(Produit p, int nb)
        {
            if (nb > 0)
            {
                if (cart.ContainsKey(p))
                {
                    cart[p] -= nb;
                    if (cart[p] <= 0)
                    {
                        cart.Remove(p);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
