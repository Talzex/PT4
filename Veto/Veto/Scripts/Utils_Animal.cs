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
        public static void SaveAnimal(Animal animal)
        {
            if (animal != null)
            {
                entities.Animal.Add(animal);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Updates the animal's infos
        /// </summary>
        /// <param name="animal">The animal to modify</param>
        /// <param name="name">The new name</param>
        /// <param name="specie">The new specie</param>
        /// <param name="race">The new race</param>
        /// <param name="height">The new height</param>
        /// <param name="weight">The new weight</param>
        /// <param name="birth">The new date of birrth</param>
        public static void ModifyAnimal(Animal animal, string name, string specie, string race, int height, int weight, DateTime birth)
        {
            animal.Nom = name;
            animal.NomEspece = specie;
            animal.NomRace = race;
            animal.Poids = weight;
            animal.Taille = height;
            animal.DateDeNaissance = birth;
            entities.SaveChanges();
        }

        /// <summary>
        /// Remove the animal from the DB
        /// </summary>
        /// <param name="animal">the animal to remove</param>
        public static void RemoveAnimal(Animal animal)
        {
            entities.Animal.Remove(animal);
            entities.SaveChanges();
        }
    }
}
