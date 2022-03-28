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
        /// Query which return all the cares
        /// </summary>
        /// <returns>All the cares</returns>
        public static List<Soins> GetCaresAll()
        {
            var cares = (from data in entities.Soins
                         select data).ToList();

            return (List<Soins>)cares;
        }
    }
}
