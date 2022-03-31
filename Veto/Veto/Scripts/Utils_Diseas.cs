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
                          orderby data.NomMaladie ascending
                          select data).ToList();

            return (List<Maladie>)deseas;
        }

        /// <summary>
        /// Query which return all deseas of an animal
        /// </summary>
        /// <param name="a"> The animal </param>
        /// <returns>All the deseas of this animal</returns>
        public static List<Maladie> getDeseasAnimal(Animal a)
        {
            var deseasId = (from data in entities.MaladieAnimal
                          where data.IdAnimal == a.IdAnimal
                          select data.IdMaladie);
            var deseas = (from data in entities.Maladie
                          where deseasId.Contains(data.IdMaladie)
                          select data).ToList();
            return (List <Maladie>) deseas;
        }

        /// <summary>
        /// Add a deseas to an animal
        /// </summary>
        /// <param name="maladie"> The deseas</param>
        /// <param name="animal"> The animal</param>
        public static void addDeseasAnimal(Maladie maladie, Animal animal)
        {
            if (maladie != null && animal != null)
            {
                MaladieAnimal maladieAnimal = new MaladieAnimal
                {
                    IdMaladie = maladie.IdMaladie,
                    IdAnimal = animal.IdAnimal
                };
                entities.MaladieAnimal.Add(maladieAnimal);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// remove a deseas to an animal
        /// </summary>
        /// <param name="maladie"> The deseas </param>
        /// <param name="animal"> The animal </param>
        public static void removeDeseasAnimal(Maladie maladie, Animal animal)
        {
            var animalDeseas = (from data in entities.MaladieAnimal
                                where data.IdMaladie == maladie.IdMaladie && data.IdAnimal == animal.IdAnimal
                                select data);


            entities.MaladieAnimal.Remove((MaladieAnimal) animalDeseas);
            entities.SaveChanges();
        }
    }
}
