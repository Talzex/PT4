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
        /// Query which get a employee
        /// </summary>
        /// <param name="login">Employee's login</param>
        /// <param name="password">Employee's password</param>
        /// <returns>The employee</returns>
        public static Salarie GetEmployee(String login, String password)
        {
            var employeeQuerry = (from data in entities.Salarie
                                  where login == data.Login
                                  && password == data.MDP
                                  select data).FirstOrDefault();

            return (Salarie)employeeQuerry;
        }

        /// <summary>
        /// Query which return all the employee
        /// </summary>
        /// <returns>All the employee</returns>
        public static List<Salarie> GetEmployeeAll()
        {
            var employees = (from data in entities.Salarie
                             orderby data.Login ascending
                             select data).ToList();

            return (List<Salarie>)employees;
        }

        /// <summary>
        /// Adds an employee to the database
        /// </summary>
        /// <param name="e"></param>
        public static void SaveEmployee(Salarie e)
        {
            entities.Salarie.Add(e);
            entities.SaveChanges();
        }

        /// <summary>
        /// Modify an employee
        /// </summary>
        /// <param name="e"></param>
        public static void ModifyEmployee(Salarie e)
        {

        }

        public static void DeleteEmployee(Salarie e)
        {
            entities.Salarie.Remove(e);
            entities.SaveChanges();
        }
    }
}
