using StayFitNTier.DAL.Abstract;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StayFitNTier.DAL.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IDeleteforUserRepository<Product>, IDeleteforAdmin<Product>
    {
        StayFitDbContext c;
        public ProductRepository()
        {
            c = new StayFitDbContext();
        }
        /// <summary>
        /// Deletes product row by given product.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(Product p)
        {
            Product deletedValue = c.Products.Include(a => a.MealDetails).SingleOrDefault(a => a.Id == p.Id);
            c.Products.Remove(deletedValue);
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// change product's isactive property to false.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforUser(Product p)
        {            
            Product deletedValue = c.Products.Find(p.Id);
            deletedValue.IsActive = false;
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Gets all active products.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetActiveProducts()
        {
            return c.Products.Where(a => a.IsActive==true).ToList();
        }
        /// <summary>
        /// Gets all products by given subcategory Id.
        /// </summary>
        /// <param name="subCategoryId"></param>
        /// <returns></returns>
        public List<Product> GetProductbySubCategoryId(int subCategoryId)
        {
            return c.Products.Where(a => a.SubCategoryId== subCategoryId && a.IsActive).ToList();
        }
        /// <summary>
        /// Updates product row which had sent.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(Product p)
        {
            Product updatedValue = c.Products.Include(a => a.MealDetails).SingleOrDefault(a => a.Id == p.Id);
            updatedValue.IsActive = p.IsActive;
            updatedValue.Name = p.Name;
            updatedValue.PortionWeight = p.PortionWeight;
            updatedValue.Calories = p.Calories;
            updatedValue.Protein = p.Protein;
            updatedValue.SubCategoryId = p.SubCategoryId;
            updatedValue.HealthIndex = p.HealthIndex;
            updatedValue.Photo = p.Photo;
            return c.SaveChanges() > 0;
        }
    }
}
