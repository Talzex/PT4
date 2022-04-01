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
        /// Query which add animal to the BD
        /// </summary>
        /// <param name="animal">the animal</param>
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

        /// <summary>
        /// Query which return all the animals of a client
        /// </summary>
        /// <param name="client">the client</param>
        /// <returns>the animals</returns>
        public static List<Animal> getClientAnimals(Client client)
        {
            var animaux = (from data in entities.Animal
                           where data.IdClient == client.IdClient
                           orderby data.Nom ascending
                           select data).ToList();

            return (List<Animal>)animaux;
        }

        /// <summary>
        /// Query which add animalRDV to the BD
        /// </summary>
        /// <param name="animal">the animal</param>
        public static void SaveAnimalRDV(AnimalRDV animal)
        {
            if (animal != null)
            {
                entities.AnimalRDV.Add(animal);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Query which return a animal
        /// </summary>
        /// <param name="client">the client</param>
        /// <param name="name">animal's name</param>
        /// <returns>the animal</returns>
        public static Animal getAnimal(Client client, String name)
        {
            var animal = (from data in entities.Animal
                          where data.Nom.Contains(name)
                          select data).FirstOrDefault();

            return (Animal)animal;
        }

        /// <summary>
        /// Query which modify an AnimalRDV
        /// </summary>
        /// <param name="animalRDV">the animalRDV</param>
        /// <param name="idRdv">the rdv</param>
        /// <param name="idAnimal">the animal</param>
        public static void modifyAnimalRDV(AnimalRDV animalRDV, int idRdv, int idAnimal)
        {
            animalRDV.IdRDV = idRdv;
            animalRDV.IdAnimal = idAnimal;
            entities.SaveChanges();
        }
    }
}
