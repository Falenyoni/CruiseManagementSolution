using CruiseManagement.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace CruiseManagement.Api.Data
{
    public class CruiseManagementDbContext : DbContext
    {
        public CruiseManagementDbContext(DbContextOptions<CruiseManagementDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Products
            //Cruise Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Ra Ikani",
                Description = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                Price = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "River Odyssey",
                Description = "A kit provided by Curology, containing skin care products",
                Price = 50,
                CategoryId = 1

            });


            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Emily"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Bongani"

            });

            // Add Agents
            modelBuilder.Entity<BookingAgent>().HasData(new BookingAgent
            {
                Id = 1,
                AgentName = "Shearwater Adventures",
                AgentTypeId = 1

            });
            modelBuilder.Entity<BookingAgent>().HasData(new BookingAgent
            {
                Id = 2,
                AgentName = "Veneto",
                AgentTypeId = 2

            });

            //Add Agent Types
            modelBuilder.Entity<AgentType>().HasData(new AgentType
            {
                Id = 1,
                Name = "Company"

            });
            modelBuilder.Entity<AgentType>().HasData(new AgentType
            {
                Id = 2,
                Name = "Walk-In"

            });


            //Create Reservation 
            modelBuilder.Entity<Reservation>().HasData(new Reservation
            {
                Id = 1,
                FirstName = "Bongani",
                MiddleName = "Fale",
                LastName = "Nyoni",
                AgentId = 1,
                UserId = 1,
                Notes = ""

            });
            modelBuilder.Entity<Reservation>().HasData(new Reservation
            {
                Id = 2,
                FirstName = "Test 2",
                MiddleName = "Test",
                LastName = "Test",
                AgentId = 2,
                UserId = 1,
                Notes = ""

            });

            // Add Reservation Items
            modelBuilder.Entity<ReservationItem>().HasData(new ReservationItem
            {
                Id = 1,
                ReservationId = 1,
                ProductId = 2,
                AdultPax = 3,
                ChildPax = 2,
                CompPax = 1,
                PickupPoint = "Elephant Hills Hotel",
                Destination = "Cruise",
                AdultPrice = 40,
                ChildPrice = 20,
                CompPrice = 16,
                Travelled = false,

            });

            modelBuilder.Entity<ReservationItem>().HasData(new ReservationItem
            {
                Id = 2,
                ReservationId = 2,
                ProductId = 1,
                AdultPax = 10,
                ChildPax = 5,
                CompPax = 4,
                PickupPoint = "Elephant Hills Hotel",
                Destination = "Cruise",
                AdultPrice = 60,
                ChildPrice = 50,
                CompPrice = 30,
                Travelled = false,

            });


            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Cruise"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Tours"
            });

        }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationItem> ReservationItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BookingAgent> BookingAgents { get; set; }
        public DbSet<AgentType> AgentTypes { get; set; }
    }

    
}
