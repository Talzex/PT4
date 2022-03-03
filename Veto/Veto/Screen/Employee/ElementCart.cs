using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto.Screen.Employee
{
    public partial class ElementCart : UserControl
    {
        Produit product = new Produit();
        public ElementCart(Produit product)
        {
            InitializeComponent();
            this.product = product;
            MAJProduit(this.product);
        }
        /// <summary>
        /// Method to update on a product
        /// </summary>
        /// <param name="product"></param>
        private void MAJProduit(Produit product)
        {
            label_product.Text = product.NomProduit;
            label_unitprice.Text = product.PrixVenteClient.ToString() + "€";
        }
    }
}
