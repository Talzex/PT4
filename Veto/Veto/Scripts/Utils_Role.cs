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
        /// Query which return all the roles
        /// </summary>
        /// <returns>All the roles</returns>
        public static List<Roles> GetRolesAll()
        {
            var roles = (from data in entities.Roles
                         orderby data.Nom ascending
                         select data).ToList();

            return (List<Roles>)roles;
        }
    }
}
