using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veto
{
    public partial class Client
    {
        public override string ToString()
        {
            return this.PrenomClient + " " + this.NomClient;
        }
    }
}
