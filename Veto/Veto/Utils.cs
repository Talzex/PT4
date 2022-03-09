using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    public class Utils
    {
        public static Entities entities = new Entities();

        
        public static List<Client> GetClientsAll()
        {
            var clients = from data in entities.Client
                          select data;

            return (List<Client>) clients;
        }
        

        public static Salarie GetSalarie(String login, String password)
        {
            var salarieQuerry = (from data in entities.Salarie
                                 where login == data.Login
                                 && password == data.MDP
                                 select data).FirstOrDefault();

            return (Salarie) salarieQuerry;
        }
    
    }
}
