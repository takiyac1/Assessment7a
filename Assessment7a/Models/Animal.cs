namespace Assessment7a.Models
{
    public class Animal
    {
        private static List<Animal> Animals = new List<Animal>();
        private static int NextId = 1;
        public int id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public List<Species>SpeciesName { get; set; }

        public static List<Animal> GetAll() { return Animals; }

       public Animal() { }
    }
}
