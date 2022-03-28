using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veto
{
    public partial class Produit
    {
        public override string ToString()
        {
            return this.NomProduit;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Produit))
            {
                return false;
            }
            Produit p = (Produit)obj;
            return p.IdProduit == this.IdProduit;
        }
    }
}
