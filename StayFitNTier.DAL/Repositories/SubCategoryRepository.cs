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
    public class SubCategoryRepository : BaseRepository<SubCategory>, IDeleteforUserRepository<SubCategory>, IDeleteforAdmin<SubCategory>
    {
        StayFitDbContext c;
        public SubCategoryRepository()
        {
            c = new StayFitDbContext();
        }
        /// <summary>
        /// Deletes given subcategory.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(SubCategory p)
        {
            SubCategory deletedValue = c.SubCategories.Include(a => a.Products).SingleOrDefault(b => b.Id == p.Id);
            c.SubCategories.Remove(deletedValue);
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Changes given subcatory's isacctive property to false.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforUser(SubCategory p)
        {            
            SubCategory deletedValue = c.SubCategories.Find(p.Id);
            deletedValue.IsActive = false;
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Gets all active subcatogories.
        /// </summary>
        /// <returns></returns>
        public List<SubCategory> GetActiveSubcategories()
        {
            return c.SubCategories.Where(a =>  a.IsActive).ToList();
        }
        /// <summary>
        /// Gets all subcatogories which had added by user.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public List<SubCategory> GetSubCategorybyCategoryId(int categoryId)
        {
            return c.SubCategories.Where(a => a.CategoryId == categoryId && a.IsActive).ToList();
        }
        /// <summary>
        /// Updates given row with new values.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(SubCategory p)
        {
            SubCategory updatedValue = c.SubCategories.Find(p.Id);
            updatedValue.Name = p.Name;
            updatedValue.CategoryId = p.CategoryId;
            updatedValue.Photo = p.Photo;
            updatedValue.IsActive = p.IsActive;
            return c.SaveChanges() > 0;
        }
    }
}
