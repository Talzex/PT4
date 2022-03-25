using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veto
{
    public static partial class Utils
    {
        /// <summary>
        /// Query which add a invoice to the BD
        /// </summary>
        /// <param name="invoice">the invoice</param>
        public static void SaveInvoice(Facture invoice)
        {
            if (invoice != null)
            {
                entities.Facture.Add(invoice);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which add product invoices to the BD
        /// </summary>
        /// <param name="productInvoice">product invoices</param>
        public static void SaveProductInvoices(List<ProduitFacture> productInvoice)
        {
            if (productInvoice != null)
            {
                foreach (ProduitFacture p in productInvoice)
                {
                    entities.ProduitFacture.Add(p);
                }
                entities.SaveChanges();
            }
        }
    }
}
