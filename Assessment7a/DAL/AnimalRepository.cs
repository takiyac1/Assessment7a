using Assessment7a.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment7a.DAL
{
    public class BoardGameRepository
    {
        private AnimalContext _dbContext = new AnimalContext();

      

        public List<Animal> GetAllAnimals()
        {
            return _dbContext.Animals.ToList();
        }

        public List<Species> ListSpecies(string name)
        {
            return _dbContext.SpeciesList.ToList();
        }






    }
}