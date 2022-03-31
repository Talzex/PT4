using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Veto
{
    public partial class Cart : Veto.ScreenEmployee
    {

        private Dictionary<Produit, int> cart;
        private Client buyer;
        private double total;
        private string filePath = "";


        public Cart() { InitializeComponent(); }

        public Cart(Salarie user) : base(user)
        {
            InitializeComponent();
            cart = new Dictionary<Produit, int>();
            ClientsCB.Items.AddRange(Utils.GetClientsAll().ToArray());
            total = 0;
            foreach (string printer in PrinterSettings.InstalledPrinters)
                PrinterCB.Items.Add(printer);
        }

        /// <summary>
        /// Displays the products in the cart
        /// </summary>
        private void DisplayProducts()
        {
            total = 0;
            Panel_AllProducts.Controls.Clear();
            foreach (Produit product in cart.Keys)
            {
                int nb; cart.TryGetValue(product, out nb);
                var elementCart = new ElementCart(product, nb);
                Panel_AllProducts.Controls.Add(elementCart);
                total += nb * product.PrixVenteClient;
            }
            TotalLBL.Text = "Total : " + total;
        }



        /// <summary>
        /// Adds a product with a certain quantity to the cart (if it's possible)
        /// </summary>
        /// <param name="p">The product to add</param>
        /// <param name="nb">The quantity to add</param>
        /// <returns>The quantity in the cart</returns>
        public int AddProduct(Produit p, int nb)
        {
            int returnValue = 0;
            if (!cart.ContainsKey(p))
            {
                if (nb > 0)
                {
                    if (nb > p.QuantiteEnStock)
                    {
                        nb = p.QuantiteEnStock;
                    }
                    cart.Add(p, nb);
                    total += nb * p.PrixVenteClient;
                    returnValue = nb;
                    return nb;
                }
            }
            else
            {
                if (nb > 0)
                {
                    if (nb + cart[p] > p.QuantiteEnStock)
                    {
                        nb = p.QuantiteEnStock - cart[p];
                    }
                    total += nb * p.PrixVenteClient;
                    cart[p] += nb;
                }
                returnValue = cart[p];
            }
            TotalLBL.Text = "Total : " + total;
            return returnValue;
        }

        /// <summary>
        /// Removes a certain quantity of a product from the cart (if it's possible)
        /// </summary>
        /// <param name="p">The product to remove</param>
        /// <param name="nb">The quantity to remove</param>
        /// <returns>If the display should be removed (when the new quantity is under or equal to 0)</returns>
        public bool RemoveProduct(Produit p, int nb)
        {
            bool returnValue = false;
            if (nb > 0 && cart.ContainsKey(p))
            {
                int nbRemove = 0;
                if (nb >= cart[p])
                {
                    nbRemove = cart[p];
                    cart.Remove(p);
                    returnValue = true;
                }
                else
                {
                    nbRemove = nb;
                    cart[p] -= nbRemove;
                }
                total -= nbRemove * p.PrixVenteClient;
            }
            TotalLBL.Text = "Total : " + total;
            return returnValue;
        }



        #region Input

        /// <summary>
        /// Every time the form is shown on screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cart_Activated(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        /// <summary>
        /// Chooses a client for the current cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_login_Click(object sender, EventArgs e)
        {
            if (ClientsCB.SelectedItem != null)
            {
                buyer = (Client)ClientsCB.SelectedItem;
                CustomerLBL.Text = buyer.ToString();
            }
        }

        /// <summary>
        /// Saves the bill in the "Bills" repository
        /// </summary>
        /// <param name="content">The string content of the bill</param>
        /// <param name="now">The date at which the bill was generated</param>
        private void SaveFile(string content, DateTime now, Facture f)
        {
            string folder = Path.Combine(Application.StartupPath, "Bills");
            Directory.CreateDirectory(folder);

            string fileName = now.ToString("yyyy-MM-dd") + "_" + f.IdFacture + "-" + f.Client.NomClient + "-" + f.Client.PrenomClient + ".txt";
            File.WriteAllText(Path.Combine("Bills", fileName), content);

            filePath = Path.Combine(folder, fileName);
        }

        /// <summary>
        /// Creates and saves a bill for the Items in the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_validate_Click(object sender, EventArgs e)
        {
            if (cart.Count > 0 && buyer != null)
            {
                DateTime now = DateTime.Now;

                Facture f = new Facture();
                f.NumeroFacture = f.IdFacture;
                f.DateFacture = now;
                f.Montant = (int)total;
                f.IdClient = buyer.IdClient;
                f.Client = buyer;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Date d'émission " + now.ToString());
                sb.AppendLine("Numéro de facture : " + f.IdFacture);
                sb.AppendLine("Date de vente " + now.ToString());
                sb.AppendLine("Dénomination : " + "Annie Maux Best Véto ©");
                sb.AppendLine("Siège social : " + "123 Animal Land");
                sb.AppendLine("Siren : " + "Pin Pon Pin Pon");
                sb.AppendLine("Code NAF : " + "651516515");
                sb.AppendLine("Acheteur : " + buyer.ToString());

                List<ProduitFacture> productsBill = new List<ProduitFacture>();
                foreach (Produit p in cart.Keys)
                {
                    ProduitFacture pf = new ProduitFacture();
                    pf.Quantite = cart[p];
                    pf.IdFacture = f.IdFacture;
                    pf.IdProduit = p.IdProduit;

                    sb.AppendLine(p + " : " + pf.Quantite + " x " + p.PrixVenteClient + "€ (0% de TVA)");
                }
                sb.AppendLine("Total (HT) : " + total);
                sb.AppendLine("Total (TTC) : " + total);
                sb.AppendLine("Date de paiement : " + now.ToString());
                sb.AppendLine("Réduction en cas de paiement anticipé : 0€");
                sb.AppendLine("Pénalité en cas de retard de paiement : Mort (ou 40€)");

                SaveFile(sb.ToString(), now, f);
            } else
            {
                MessageBox.Show("Le panier ne doit pas être videet un client doit être authentifié ! ");
            }
        }

        /// <summary>
        /// Prints the bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_bill_Click(object sender, EventArgs e)
        {
            if (filePath.Equals(""))
            {
                MessageBox.Show("Attention, le panier doit être validé avant l'impression");
            }
            else
            {
                BillPrint bp = new BillPrint(filePath);
                bp.LaunchPrint();
            }
        }

        /// <summary>
        /// Empties the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_empty_Click(object sender, EventArgs e)
        {
            cart.Clear();
            DisplayProducts();
        }

        #endregion
        
    }
}
