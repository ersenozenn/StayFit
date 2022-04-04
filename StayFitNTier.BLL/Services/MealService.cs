using StayFitNTier.DAL.Repositories;
using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.BLL.Services
{
    public class MealService
    {
        MealRepository mealRepository;
        public MealService()
        {
            mealRepository = new MealRepository();
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
        /// Get meal by given Id.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public Meal GetById(int mealId)
        {
            CheckId(mealId);
            return mealRepository.GetById(mealId);
        }
        /// <summary>
        /// Add given meal to database.
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public bool AddMeal(Meal meal)
        {
            return mealRepository.Insert(meal);
        }
        /// <summary>
        /// Gets all meals.
        /// </summary>
        /// <returns></returns>
        public List<Meal> GetMeals()
        {
            return mealRepository.List();
        }
        /// <summary>
        /// Get meals by repast Id.
        /// </summary>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public List<Meal> GetMealsbyRepastId(int repastId)
        {
            CheckId(repastId);
            return mealRepository.GetByRepastId(repastId);
        }
        /// <summary>
        /// Deletes given meal.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(int mealId)
        {
            CheckId(mealId);
            Meal meal = GetById(mealId);
            return mealRepository.DeleteforAdmin(meal);
        }
        /// <summary>
        /// Updates given meal.
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public bool UpdateMeal(Meal meal)
        {
            return mealRepository.Update(meal);
        }
        /// <summary>
        /// Gets meals by user Id within the given dates.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <returns></returns>
        public List<Meal> GetMealbyUserId(int userId,DateTime minDate,DateTime maxDate)
        {
            return mealRepository.GetMealbyUserId(userId, minDate, maxDate);

        }
        /// <summary>
        /// Gets meals of user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Meal> GetMealbyUserId(int userId)
        {
            return mealRepository.GetMealbyUserId(userId);
        }
        /// <summary>
        /// Gets current meals of user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Meal> GetTodaysMealbyUserId(int userId)
        {
            return mealRepository.GetTodaysMealbyUserId(userId);
        }
    }
}
