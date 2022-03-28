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
        /// Query which return all the deseas
        /// </summary>
        /// <returns>All the deseas</returns>
        public static List<Maladie> GetDeseasAll()
        {
            var deseas = (from data in entities.Maladie
                          select data).ToList();

            return (List<Maladie>)deseas;
        }
    }
}
