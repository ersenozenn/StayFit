using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StayFitNTier.DAL.EntityConfiguration;
using StayFitNTier.DAL.Strategy;
using StayFitNTier.Model.Entities;

namespace StayFitNTier.DAL
{
    public class StayFitDbContext : DbContext
    {
        public StayFitDbContext() : base("Data Source = DESKTOP-5LLUNOS\\SQLEXPRESS;Initial Catalog=StayFitDB;Integrated Security=true;")
        {
            Database.SetInitializer(new FitStrategy());

        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<PhysicalActivity> PhysicalActivities { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Repast> Repasts { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProperty> UserProperties { get; set; }
        public DbSet<MealDetail> MealDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new GenderConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new PhysicalActivityConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new RepastConfiguration());
            modelBuilder.Configurations.Add(new SubCategoryConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserPropertyConfiguration());
            modelBuilder.Configurations.Add(new MealDetailConfiguration());
        }
    }
}
