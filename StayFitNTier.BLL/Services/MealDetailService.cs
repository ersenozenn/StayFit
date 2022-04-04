using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class MealDetailService
    {
        MealDetailRepository mealDetailRepository;
        public MealDetailService()
        {
            mealDetailRepository = new MealDetailRepository();
        }
        /// <summary>
        /// returns list which contains all meal details.
        /// </summary>
        /// <returns></returns>
        public List<MealDetail> GetAllMealDetails()
        {
            return mealDetailRepository.List();
        }
        /// <summary>
        /// Checks Id.
        /// </summary>
        /// <param name="Id"></param>
        void CheckId(int Id)
        {
            if (Id <= 0 ) throw new Exception("Parameter value is not suitable!");
        }
        /// <summary>
        /// Gets meal detail with meal and product Id.
        /// </summary>
        /// <param name="mealId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public MealDetail GetbyId(int mealId,int productId)
        {
            CheckId(mealId);
            CheckId(productId);
            return mealDetailRepository.GetbyKeys(mealId, productId);
        }
        /// <summary>
        /// Gets products for specific meal.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public List<Product> GetProductsforOneMeal(int mealId)
        {
            CheckId(mealId);
            return mealDetailRepository.GetProductsforOneMeal(mealId);
        }
        /// <summary>
        /// Get meals for specific product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public List<Meal> GetMealsforOneProduct(int productId)
        {
            CheckId(productId);
            return mealDetailRepository.GetMealsforOneProduct(productId);
        }
        /// <summary>
        /// Gets all meals in meal details by given Id.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public Meal GetMealsbyMealId(int mealId)
        {
            CheckId(mealId);
            return mealDetailRepository.GetMealsbyMealId(mealId);
        }
        /// <summary>
        /// Gets most preffered categories by user within the given date.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredCategoriesbyUserandDateService(int userId, DateTime minDate, DateTime maxDate)
        {
            CheckId(userId);
            return mealDetailRepository.GetMostPreferredCategoriesbyUseranDate1(userId, minDate, maxDate);
        }
        /// <summary>
        /// Gets most preffered categories by user and repast. within the given date.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredCategoriesbyUserandDateandRepast(int userId, DateTime minDate, DateTime maxDate, int repastId)
        {
            CheckId(userId);
            CheckId(repastId);

            return mealDetailRepository.GetMostPreferredCategoriesbyUser(userId, minDate, maxDate, repastId);
        }
        /// <summary>
        /// Gets most prefferred prdoducts by repastId.
        /// </summary>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredProductsbyRepast(int repastId)
        {
            CheckId(repastId);
            return mealDetailRepository.GetMostPreferredProductsbyRepast(repastId);
        }
        /// <summary>
        /// Gets most prefferred prdoducts by userId.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredProductsbyUser(int userId)
        {
            CheckId(userId);
            return mealDetailRepository.GetMostPreferredProductsbyUser(userId);
        }
        /// <summary>
        /// Returns total calorie of user within the given date.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <returns></returns>
        public decimal GetCaloriesbyTime(int userId, DateTime minMealDate, DateTime maxMealDate)
        {
            CheckId(userId);
            return mealDetailRepository.GetCaloriesbyTime(userId, minMealDate, maxMealDate);
        }
        /// <summary>
        /// Returns total protein of user within the given date.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <returns></returns>
        public decimal GetProteinbyTime(int userId, DateTime minMealDate, DateTime maxMealDate)
        {
            CheckId(userId);
            return mealDetailRepository.GetProteinbyTime(userId, minMealDate, maxMealDate);
        }
        /// <summary>
        /// Returns average healthh index of user within the given date.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <returns></returns>
        public decimal GetHealthIndexbyTime(int userId, DateTime minMealDate, DateTime maxMealDate)
        {
            CheckId(userId);
            return mealDetailRepository.GetHealthIndexbyTime(userId, minMealDate, maxMealDate);
        }
        /// <summary>
        /// Returns total calories of user by repast within the given date.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public decimal GetCaloriesbyRepast(int userId, DateTime minMealDate, DateTime maxMealDate, int repastId)
        {
            CheckId(userId);
            CheckId(repastId);
            return mealDetailRepository.GetCaloriesbyRepast(userId, minMealDate, maxMealDate, repastId);
        }
        /// <summary>
        /// Returns total protein of user by repast within the given date.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public decimal GetProteinbyRepast(int userId, DateTime minMealDate, DateTime maxMealDate, int repastId)
        {
            CheckId(userId);
            CheckId(repastId);
            return mealDetailRepository.GetProteinbyRepast(userId, minMealDate, maxMealDate, repastId);
        }
        /// <summary>
        /// Returns average health index of user by repast within the given date.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public decimal GetHealthIndexbyRepast(int userId, DateTime minMealDate, DateTime maxMealDate, int repastId)
        {
            CheckId(userId);
            CheckId(repastId);
            return mealDetailRepository.GetHealthIndexbyRepast(userId, minMealDate, maxMealDate, repastId);
        }
        /// <summary>
        /// Deletes meal detail with given meal and product id.
        /// </summary>
        /// <param name="mealId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(int mealId,int productId)
        {
            MealDetail mealDetail = GetbyId(mealId, productId);
            return mealDetailRepository.DeleteforAdmin(mealDetail);
        }
        /// <summary>
        /// Updates given meal detail.
        /// </summary>
        /// <param name="mealDetail"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(MealDetail mealDetail)
        {            
            return mealDetailRepository.UpdateforAdmin(mealDetail);
        }
        /// <summary>
        /// Get meal details for specific meal.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public List<MealDetail> GetMealDetailsforOneMeal(int mealId)
        {
            return mealDetailRepository.GetMealDetailsforOneMeal(mealId);

        }
        /// <summary>
        /// Return total calories for specific meal.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public decimal GetCaloriesforOneMeal(int mealId)
        {
            CheckId(mealId);
            return mealDetailRepository.GetCaloriesforOneMeal(mealId);
        }
        /// <summary>
        /// Return total protein for given meal.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public decimal GetProteinforOneMeal(int mealId)
        {
            CheckId(mealId);
            return mealDetailRepository.GetProteinforOneMeal(mealId);
        }
        /// <summary>
        /// Adds new meal detail to database.
        /// </summary>
        /// <param name="mealDetail"></param>
        /// <returns></returns>
        public bool AddMealDetail(MealDetail mealDetail)
        {
            return mealDetailRepository.Insert(mealDetail);
        }
        /// <summary>
        /// Gets most preffered categories within given date.
        /// </summary>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <returns></returns>
        public Dictionary<int,int> GetMostPrefferredCategoriesbyDate(DateTime minDate,DateTime maxDate)
        {
            return mealDetailRepository.GetMostPreferredCategoriesbyDate(minDate, maxDate);
        }
        /// <summary>
        /// Gets most preffered categories by repast within given date.
        /// </summary>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredCategoriesforGeneralbyRepast(DateTime minDate, DateTime maxDate,int repastId )
        {
            return mealDetailRepository.GetMostPreferredCategoriesforGeneralbyRepast(minDate, maxDate, repastId);
        }
        /// <summary>
        /// Gets all most preffered products.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredProducts()
        {           
            return mealDetailRepository.GetMostPreferredProducts() ;
        }
    }
}
