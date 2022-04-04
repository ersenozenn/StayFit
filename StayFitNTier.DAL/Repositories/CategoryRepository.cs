using StayFitNTier.DAL.Abstract;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, IDeleteforUserRepository<Category> , IDeleteforAdmin<Category> 
    {
        StayFitDbContext c;
        public CategoryRepository()
        {
            c = new StayFitDbContext();
        }
        /// <summary>
        /// Deletes category which had sent. 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(Category p)
        {
            Category deletedValue = c.Categories.Include(a=>a.SubCategories).SingleOrDefault(a=>a.Id==p.Id);
            c.Categories.Remove(deletedValue);
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Updates category which had sent. 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(Category p)
        {
            Category updatedValue = c.Categories.Find(p.Id);
            updatedValue.Name = p.Name;
            updatedValue.Photo = p.Photo;
            updatedValue.IsActive = p.IsActive;
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// changes the isactive column to false for given category.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforUser(Category p)
        {            
            Category deletedValue = c.Categories.Find(p.Id);
            deletedValue.IsActive = false;
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// List all active categories.
        /// </summary>
        /// <returns></returns>
        public List<Category> GetActiveCategories()
        {
            return c.Categories.Where(a => a.IsActive).ToList();
        }
        /// <summary>
        /// Gets category within given productId.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public int GetCategoryIdbyProductId(int productId)
        {
            var list = c.Categories.Join(c.SubCategories, c => c.Id, s => s.CategoryId, (c, s) => new { subCategoryId = s.Id, categoryId = c.Id }).Join(c.Products, c => c.subCategoryId, p => p.SubCategoryId, (c, p) => new { c.categoryId, p.Id }).Where(a => a.Id == productId).FirstOrDefault();
            return list.categoryId; 
        }
        /// <summary>
        /// Gets subcategory within given subcategoryId.
        /// </summary>
        /// <param name="subCategoryıd"></param>
        /// <returns></returns>
        public int GetCategoryIdbySubCategoryId(int subCategoryıd)
        {
            var list = c.Categories.Join(c.SubCategories, c => c.Id, s => s.CategoryId, (c, s) => new { subCategoryId = s.Id, categoryId = c.Id }).Where(a=>a.subCategoryId== subCategoryıd).FirstOrDefault();
            return list.categoryId;
        }
    }
}
