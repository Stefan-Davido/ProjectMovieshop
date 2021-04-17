namespace Movieshop.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Movieshop.Entities;
    using System;

    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        // *** have to tell the datacontext about our models ***
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<Production> Production { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<ShoppingCard> ShoppingCard { get; set; }
        public DbSet<WatchLatter> WatchLatter { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ***** Data Seed *****

            #region Admin and Roles

            const string ADMIN_ID = "b4280b6a-0613-4cbd-a9e6-f1701e926e73";
            const string ROLE_ID = ADMIN_ID;
            const string password = "admin123abc!";

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ID,
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "b4280b6a -0613-4cbd-a9e6-f1701e926e74",
                    Name = "editor",
                    NormalizedName = "EDITOR"
                },
                new IdentityRole
                {
                    Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                    Name = "guest",
                    NormalizedName = "GUEST"
                });

            var hashPassword = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id= ADMIN_ID,
                    UserName = "admin@movieshop.com",
                    NormalizedUserName = "ADMIN@MOVIESHOP.COM",
                    Email = "admin@movieshop.com",
                    NormalizedEmail = "ADMIN@MOVIESHOP.COM",
                    EmailConfirmed = true,
                    PasswordHash = hashPassword.HashPassword(null, password),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = "c8554266 -b401-4519-9aeb-a9283053fc58"
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ROLE_ID,
                    UserId = ADMIN_ID
                });

            #endregion
            #region Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1 ,
                    Title = "San Andreas",
                    ProducerId = 4,
                    ProducerName = "Jerry Bruckheimer",
                    ActersId = 8,
                    ActersName = "Dwayne Johnson-The Rock",
                    CategoryId = 2, 
                    CategoryName = "Action",
                    GenreId = 9,
                    GenreName = "Thriller",
                    ProductionId = 7,
                    ProductionName = "New Line Cinema",
                    TimeLast =  1.54, 
                    YearsToWatch = 12,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "In the aftermath of a massive earthquake " +
                    "in California, a rescue-chopper " +
                    "pilot makes a dangerous journey with his ex-wife " +
                    "across the state in order to rescue his daughter.",
                    Language = "English",
                    Country = "USA",
                    Price = 9.90,
                    Rating = 6.1,
                    Awards = 2,
                    URL = "San_Andreas_poster.jpg"
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Fate of the Furious",
                    ProducerId = 3,
                    ProducerName = "Kevin Feige",
                    ActersId = 4,
                    ActersName = "Jason Statham",
                    CategoryId = 2, 
                    CategoryName = "Action",
                    GenreId = 8,
                    GenreName = "Crime",
                    ProductionId = 1,
                    ProductionName = "Universal Pictures",
                    TimeLast =  2.24, 
                    YearsToWatch = 16,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "When a mysterious woman seduces Dominic Toretto" +
                    " into the world of terrorism and a betrayal of those closest to him," +
                    " the crew face trials that will test them as never before",
                    Language = "English",
                    Country = "USA",
                    Price = 6.99,
                    Rating = 6.7,
                    Awards = 7,
                    URL = "fateofthefurious.jpg"
                },
                new Movie
                {
                    Id = 3,
                    Title = "Mr. & Mrs. Smith ",
                    ProducerId = 6,
                    ProducerName = "Kathleen Kennedy",
                    ActersId = 3,
                    ActersName = "Angelina Jolie",
                    CategoryId = 2, 
                    CategoryName = "Action",
                    GenreId = 5,
                    GenreName = "Comedy",
                    ProductionId = 7,
                    ProductionName = "New Line Cinema",
                    TimeLast =  2.6, 
                    YearsToWatch = 16,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "A bored married couple is surprised to learn" +
                    " that they are both assassins hired by competing agencies to kill each other.",
                    Language = "English",
                    Country = "USA",
                    Price = 5.49,
                    Rating = 6.5,
                    Awards = 5,
                    URL = "smithFamily.jpg"
                },
                new Movie
                {
                    Id = 4,
                    Title = "Rambo: Last Blood",
                    ProducerId = 5,
                    ProducerName = "David Heyman",
                    ActersId = 1,
                    ActersName = " ‎Sylvester Stallone",
                    CategoryId = 2, 
                    CategoryName = "Action",
                    GenreId = 9,
                    GenreName = "Thriller",
                    ProductionId = 4,
                    ProductionName = "Columbia Pictures",
                    TimeLast =  1.33, 
                    YearsToWatch = 16,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "Rambo must confront his past and unearth his ruthless combat skills" +
                    " to exact revenge in a final mission.",
                    Language = "English",
                    Country = "USA",
                    Price = 6.89,
                    Rating = 6.1,
                    Awards = 4,
                    URL = ""
                },
                new Movie
                {
                    Id = 5,
                    Title = "Colette ",
                    ProducerId = 6,
                    ProducerName = "Kathleen Kennedy",
                    ActersId = 6,
                    ActersName = " Keira Knightley",
                    CategoryId = 4, 
                    CategoryName = "Drama",
                    GenreId = 10,
                    GenreName = "Biography",
                    ProductionId = 3,
                    ProductionName = "20th Century",
                    TimeLast =  1.52, 
                    YearsToWatch = 8,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "Colette is pushed by her husband to write novels under his name. " +
                    "Upon their success, she fights" +
                    " to make her talents known, challenging gender norms.",
                    Language = "English",
                    Country = "USA",
                    Price = 5.79,
                    Rating = 6.7,
                    Awards = 1,
                    URL = "colette.jpg"
                },
                new Movie
                {
                    Id = 6,
                    Title = "Cocktail",
                    ProducerId = 4,
                    ProducerName = "Jerry Bruckheimer",
                    ActersId = 7,
                    ActersName = "Tom Cruise",
                    CategoryId = 5, 
                    CategoryName = "Comedy",
                    GenreId = 1,
                    GenreName = "Romance",
                    ProductionId = 6,
                    ProductionName = "Universal Studios",
                    TimeLast =  1.49, 
                    YearsToWatch = 12,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = " talented New York City bartender takes a job at a bar" +
                    " in Jamaica and falls in love.",
                    Language = "English",
                    Country = "USA",
                    Price = 6.89,
                    Rating = 5.9,
                    Awards = 5,
                    URL = "coctail.jpg"
                },
                new Movie
                {
                    Id = 7,
                    Title = "Titanic",
                    ProducerId = 1,
                    ProducerName = "James Cameron",
                    ActersId = 9,
                    ActersName = "Leonardo DiCaprio",
                    CategoryId = 4 ,
                    CategoryName = "Drama",
                    GenreId = 1,
                    GenreName = "Romance",
                    ProductionId = 3,
                    ProductionName = "20th Century",
                    TimeLast =  3.20, 
                    YearsToWatch = 8,
                    Realise = DateTime.Now,
                    DateAdded = DateTime.Now,
                    Description = "A seventeen - year - old aristocrat falls in love with a kind" +
                    " but poor artist aboard the luxurious, ill - fated R.M.S.Titanic.",
                    Language = "English",
                    Country = "USA",
                    Price = 9.99,
                    Rating = 7.8,
                    Awards = 11,
                    URL = "titanic_.jpg"
                }
            );
            #endregion

            #region Actor
            modelBuilder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = 1,
                    Name="Silvester Stalone",
                    BirthDate = DateTime.Now,
                    Country = "USA",
                    Awards = "33",
                    Gender = "Male",
                    YearsActive = "1968–present"
                },
                new Actor
                {
                    Id = 2,
                    Name="Brad Pitt",
                    BirthDate = DateTime.Now,
                    Country = "USA",
                    Awards = "119",
                    Gender = "Male",
                    YearsActive = " 1987–present"
                },
                new Actor
                {
                    Id = 3,
                    Name="Angelina Jolie",
                    BirthDate = DateTime.Now,
                    Country = "USA",
                    Awards = "60",
                    Gender = "Female",
                    YearsActive = "1982–present"
                },
                new Actor
                {
                    Id = 4,
                    Name= "Jason Statham",
                    BirthDate = DateTime.Now,
                    Country = "UK",
                    Awards = "1",
                    Gender = "Male",
                    YearsActive = "1993–present"
                },
                new Actor
                {
                    Id = 5,
                    Name= "Julia Roberts",
                    BirthDate = DateTime.Now,
                    Country = "USA",
                    Awards = "61",
                    Gender = "Female",
                    YearsActive = " 1987–present"
                },
                new Actor
                {
                    Id = 6,
                    Name= "Keira Knightley",
                    BirthDate = DateTime.Now,
                    Country = "UK",
                    Awards = "24",
                    Gender = "Female",
                    YearsActive = "1993–present"
                },
                 new Actor
                 {
                     Id = 7,
                     Name = "Tom Cruise",
                     BirthDate = DateTime.Now,
                     Country = "USA",
                     Awards = "36",
                     Gender = "Male",
                     YearsActive = " 1981–present"
                 },
                 new Actor
                 {
                     Id = 8,
                     Name = "Dwayne Johnson-The Rock",
                     BirthDate = DateTime.Now,
                     Country = "USA",
                     Awards = "16",
                     Gender = "Male",
                     YearsActive = " 1999–present"
                 },
                 new Actor
                 {
                     Id = 9,
                     Name = "Leonardo DiCaprio",
                     BirthDate = DateTime.Now,
                     Country = "USA",
                     Awards = "99",
                     Gender = "Male",
                     YearsActive = "1989–present"
                 }
             );
            #endregion

            #region Category
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name = "Romance" },
                new Category {Id = 2, Name = "Action"},
                new Category {Id = 3, Name = "Sci-Fi"},
                new Category {Id = 4, Name = "Drama"},
                new Category {Id = 5, Name = "Comedy"},
                new Category {Id = 6, Name = "Horror" },
                new Category {Id = 7, Name = "Adventure"},
                new Category {Id = 8, Name = "Crime"},
                new Category {Id = 9, Name = "Thriller" },
                new Category {Id = 10, Name = "Biography" },
                new Category {Id = 11, Name = "History" },
                new Category {Id = 12, Name = "Undefined"}
             );
            #endregion

            #region Genre
            modelBuilder.Entity<Genre>().HasData(
               new Genre { Id = 1, Name = "Romance" },
               new Genre { Id = 2, Name = "Action" },
               new Genre { Id = 3, Name = "Sci-Fi" },
               new Genre { Id = 4, Name = "Drama" },
               new Genre { Id = 5, Name = "Comedy" },
               new Genre { Id = 6, Name = "Horror" },
               new Genre { Id = 7, Name = "Adventure" },
               new Genre { Id = 8, Name = "Crime" },
               new Genre { Id = 9, Name = "Thriller" },
               new Genre { Id = 10, Name = "Biography" },
               new Genre { Id = 11, Name = "History" },
               new Genre { Id = 12, Name = "Undefined" }
            );
            #endregion

            #region Production
            modelBuilder.Entity<Production>().HasData(
                new Production
                {
                    Id= 1,
                    Name = "Universal Pictures",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 2,
                    Name = "Warner Brothers",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 3,
                    Name = "20th Century",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 4,
                    Name = "Columbia Pictures",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 5,
                    Name = "Walt Disney Pictures",
                    Country = "USA",
                    Year = DateTime.Now
                },  
                new Production
                {
                    Id= 6,
                    Name = "Universal Studios",
                    Country = "USA",
                    Year = DateTime.Now
                },
                new Production
                {
                    Id= 7,
                    Name = "New Line Cinema",
                    Country = "USA",
                    Year = DateTime.Now
                }   
            );
            #endregion
            
            #region Producer
            modelBuilder.Entity<Producer>().HasData(
                new Producer { 
                    Id = 1,
                    Name = "James Cameron",
                    Country = "Canada",
                    BirthDate = DateTime.Now,
                    YearsActive = "1974–present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 2,
                    Name = "Gore Verbinski",
                    Country = "USA",
                    BirthDate = DateTime.Now,
                    YearsActive = "	1989–present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 3,
                    Name = "Kevin Feige",
                    Country = "USA",
                    BirthDate = DateTime.Now,
                    YearsActive = "2000–present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 4,
                    Name = "Jerry Bruckheimer",
                    Country = "USA",
                    BirthDate = DateTime.Now,
                    YearsActive = "1972–present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 5,
                    Name = "David Heyman",
                    Country = "UK",
                    BirthDate = DateTime.Now,
                    YearsActive = "1992-present",
                    Gender = "Male"
                },
                new Producer { 
                    Id = 6,
                    Name = "Kathleen Kennedy",
                    Country = "USA",
                    BirthDate = DateTime.Now,
                    YearsActive = "1979–present",
                    Gender = "Female"
                }
            );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
