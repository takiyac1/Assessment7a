using Assessment7a.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment7a.DAL
{
    public class AnimalContext: DbContext

        {

            public AnimalContext()

            {


            }


            public AnimalContext(DbContextOptions options) : base(options)

            {


            }


            public DbSet<Animal> Animals { get; set; }
            public DbSet<Species>SpeciesList { get; set; }


            private static IConfigurationRoot _configuration;


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            {

                if (!optionsBuilder.IsConfigured)

                {

                    var builder = new ConfigurationBuilder()

                        .SetBasePath(Directory.GetCurrentDirectory())

                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);


                    _configuration = builder.Build();

                    string cnstr = _configuration.GetConnectionString("AnimalDb");

                    optionsBuilder.UseSqlServer(cnstr);

                }

            }

        }



    }

