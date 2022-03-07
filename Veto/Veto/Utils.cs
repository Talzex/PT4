using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    class Utils
    {
        public static Entities entities = new Entities();

        public static List<Client> GetClientsAll()
        {
            var clients = from data in entities.Client
                          select data;
            return clients.ToList<Client>();
        }


    
    }
}
