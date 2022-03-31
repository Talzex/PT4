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
        public static List<Maladie> GetDiseaseAll()
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
        public static List<Maladie> GetDiseasesAnimal(Animal a)
        {
            var diseaseId = (from data in entities.MaladieAnimal
                            where data.IdAnimal == a.IdAnimal
                            select data.IdMaladie);
            var disease = (from data in entities.Maladie
                          where diseaseId.Contains(data.IdMaladie)
                          select data).ToList();
            return (List<Maladie>)disease;
        }

        /// <summary>
        /// Adds a disease to an animal
        /// </summary>
        /// <param name="disease"> The disease</param>
        /// <param name="animal"> The animal</param>
        public static MaladieAnimal AddDiseaseAnimal(Maladie disease, Animal animal)
        {
            if (disease != null && animal != null)
            {
                MaladieAnimal da = new MaladieAnimal
                {
                    IdMaladie = disease.IdMaladie,
                    IdAnimal = animal.IdAnimal
                };
                entities.MaladieAnimal.Add(da);
                entities.SaveChanges();
                return da;
            }
            return null;
        }

        /// <summary>
        /// Remove a deseas to an animal
        /// </summary>
        /// <param name="maladie"> The deseas </param>
        /// <param name="animal"> The animal </param>
        public static void RemoveDiseaseAnimal(MaladieAnimal disease)
        {
            entities.MaladieAnimal.Remove(disease);
            entities.SaveChanges();
        }
    }
}
