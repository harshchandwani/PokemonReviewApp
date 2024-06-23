using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options)
            //base is basically pushing the data to the DB
        {
            
        }
        //importing all the models
        //always plural
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonOwner> PokemonsOwner { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        //used to override the model creation, to customize the model creation process
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the entity PokemonCategory and specify a composite primary key.
            // A composite primary key is made up of multiple columns, in this case, PokemonId and CategoryId.
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(pc => new { pc.PokemonId, pc.CategoryId
            });
        }

    }
}
