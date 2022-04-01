using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Veto
{
    public partial class ElementCart : UserControl
    {
        Produit product;
        int quantity;

        public ElementCart(Produit product, int nb)
        {
            InitializeComponent();
            this.product = product;
            quantity = nb;
            MAJProduit();
        }

        /// <summary>
        /// Updates the displayed data
        /// </summary>
        /// <param name="product"></param>
        private void MAJProduit()
        {
            QuantityTB.Text = quantity + "";
            ProductLBL.Text = product.NomProduit;
            UnitPriceLBL.Text = product.PrixVenteClient.ToString() + "€";
        }

        #region Inputs

        /// <summary>
        /// Adds 1 Item to the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_add_Click(object sender, EventArgs e)
        {
            AddItem(1);
        }

        /// <summary>
        /// Removes 1 Item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_less_Click(object sender, EventArgs e)
        {
            RemoveItem(1);
        }

        /// <summary>
        /// Removes the Product from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_remove_Click(object sender, EventArgs e)
        {
            RemoveItem(quantity);
        }

        /// <summary>
        /// Triggers when a key is pressed while the Quantity TextBox is focused
        /// Validates the new quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(((char)Keys.Enter)))
            {
                if (Int32.TryParse(QuantityTB.Text, out int newQuantity))
                {
                    if (newQuantity >= quantity)
                        AddItem(newQuantity - quantity);
                    else
                        RemoveItem(quantity - newQuantity);
                }
            }
        }

        #endregion

        /// <summary>
        /// Removes a certain quantity of the product from the cart
        /// </summary>
        /// <param name="nb">The number of items to remove</param>
        private void RemoveItem(int nb)
        {
            quantity -= nb;
            if (FormController.RemoveItemFromCart(product, nb))
            {
                Parent.Controls.Remove(this);
            }
            else
            {
                MAJProduit();
            }
        }

        /// <summary>
        /// Adds a certain quantity of the product to the cart
        /// </summary>
        /// <param name="nb">The number of items to add</param>
        private void AddItem(int nb)
        {
            quantity = FormController.AddItemToCart(product, nb);
            MAJProduit();
        }

        
    }
}

