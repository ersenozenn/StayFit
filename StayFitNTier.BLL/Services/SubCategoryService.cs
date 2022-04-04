using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class SubCategoryService
    {
        SubCategoryRepository subCategoryRepository;
        public SubCategoryService()
        {
            subCategoryRepository = new SubCategoryRepository();
        }
        /// <summary>
        /// Checks the correctness of the given number.
        /// </summary>
        /// <param name="Id"></param>
        void CheckId(int Id)
        {
            if (Id <= 0) throw new Exception("Parameter value is not suitable!");
        }
        /// <summary>
        /// Gets specific subcategory by repast Id.
        /// </summary>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public SubCategory GetById(int repastId)
        {
            CheckId(repastId);
            return subCategoryRepository.GetById(repastId);
        }
        /// <summary>
        /// Adds given subcategory to database.
        /// </summary>
        /// <param name="subCategory"></param>
        /// <returns></returns>
        public bool AddSubCategory(SubCategory subCategory)
        {
            return subCategoryRepository.Insert(subCategory);
        }
        /// <summary>
        /// Gets all subcategories.
        /// </summary>
        /// <returns></returns>
        public List<SubCategory> GetSubCategories()
        {
            return subCategoryRepository.List();
        }
        /// <summary>
        /// Deletes given subcategory.
        /// </summary>
        /// <param name="subCategoryId"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(int subCategoryId)
        {
            CheckId(subCategoryId);
            SubCategory subCategory = GetById(subCategoryId);
            return subCategoryRepository.DeleteforAdmin(subCategory);
        }
        /// <summary>
        /// Changes is active to  false.
        /// </summary>
        /// <param name="subCategoryId"></param>
        /// <returns></returns>
        public bool DeleteforUser(int subCategoryId)
        {
            CheckId(subCategoryId);
            SubCategory subCategory = GetById(subCategoryId);
            return subCategoryRepository.DeleteforUser(subCategory);
        }
        /// <summary>
        /// Gets all active subcategories.
        /// </summary>
        /// <returns></returns>
        public List<SubCategory> GetActiveSubcategories()
        {
            return subCategoryRepository.GetActiveSubcategories();
        }
        /// <summary>
        /// Gets all subcategies for given category Id.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public List<SubCategory> GetSubCategorybyCategoryId(int categoryId)
        {
            CheckId(categoryId);
            return subCategoryRepository.GetSubCategorybyCategoryId(categoryId);
        }
        /// <summary>
        /// Updates given subcategory.
        /// </summary>
        /// <param name="subCategory"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(SubCategory subCategory)
        {

            return subCategoryRepository.UpdateforAdmin(subCategory);
        }
    }
}
