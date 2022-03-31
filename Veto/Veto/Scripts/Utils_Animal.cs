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
        /// Query which add product invoices to the BD
        /// </summary>
        /// <param name="animal"></param>
        public static void saveAnimal(Animal animal)
        {
            if(animal != null)
            {
                entities.Animal.Add(animal);
                entities.SaveChanges();
            }
        }
    }
}
