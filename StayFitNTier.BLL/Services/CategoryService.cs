using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StayFitNTier.BLL.Services
{
    public class CategoryService
    {
        CategoryRepository categoryRepository;
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }
        /// <summary>
        /// Checks categoryId.
        /// </summary>
        /// <param name="categoryId"></param>
        void CheckCategoryId(int categoryId)
        {
            if (categoryId <= 0) throw new Exception("Parameter value is not suitable!");
        } 
        /// <summary>
        /// Deletes category.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(int categoryId)
        {
            CheckCategoryId(categoryId);
            Category category = GetbyCategoryId(categoryId);
            return categoryRepository.DeleteforAdmin(category);
        }
        /// <summary>
        /// Updates given value.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(Category category)
        {            
            return categoryRepository.UpdateforAdmin(category);
        }
        /// <summary>
        /// Deletes given Id.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool DeleteforUser(int categoryId)
        {
            CheckCategoryId(categoryId);
            Category category = GetbyCategoryId(categoryId);
            return categoryRepository.DeleteforUser(category);
        }
        /// <summary>
        /// Get all active categories.
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategoriesforUser()
        {
            return categoryRepository.GetActiveCategories();
        }
        /// <summary>
        /// Gets specific category with Id.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public Category GetbyCategoryId(int categoryId)
        {
            Category category = new Category();
            CheckCategoryId(categoryId);
            category = categoryRepository.GetById(categoryId);
            return category;

        }
        /// <summary>
        /// Adds a new row to database.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool Insert (Category category)
        {
            CheckCategoryName(category);
            category.IsActive = true;
            return categoryRepository.Insert(category);
        }
        /// <summary>
        /// Checks category name.
        /// </summary>
        /// <param name="category"></param>
        void CheckCategoryName(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.Name))
                throw new Exception("Category name can not be Empty!");
        }
        /// <summary>
        /// Gets all categories.
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories = categoryRepository.List();
            return categories;
        }
        /// <summary>
        /// Gets category Id by productId.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public int GetCategoryIdbyProductId(int productId)
        {
            return categoryRepository.GetCategoryIdbyProductId(productId);
        }
        /// <summary>
        /// Gerts CategoryId by  subcategoryId
        /// </summary>
        /// <param name="subCategoryıd"></param>
        /// <returns></returns>
        public int GetCategoryIdbySubCategoryId(int subCategoryıd)
        {
            return categoryRepository.GetCategoryIdbySubCategoryId(subCategoryıd);
        }

    }
}
