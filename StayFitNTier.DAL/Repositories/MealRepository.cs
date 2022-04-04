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
    public class MealRepository : BaseRepository<Meal>,  IDeleteforAdmin<Meal>
    {
        StayFitDbContext c;
        public MealRepository()
        {
            c = new StayFitDbContext();
        }
        /// <summary>
        /// Gets all meals which contains given repast.
        /// </summary>
        /// <param name="repastID"></param>
        /// <returns></returns>
        public List<Meal> GetByRepastId(int repastID)
        {            
            return c.Meals.Where(a => a.RepastId == repastID ).ToList();
        }
        
        /// <summary>
        /// Deletes meal row by given meal.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(Meal p)
        {
            Meal deletedValue = c.Meals.Include(a => a.MealDetails).SingleOrDefault(a => a.Id == p.Id);
            c.Meals.Remove(deletedValue);
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Updates meal row by given meal.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Update(Meal p)
        {
            Meal updatedValue = c.Meals.Find(p.Id);
            updatedValue.Id =  p.Id;
            updatedValue.Name = p.Name;
            updatedValue.RepastId = p.RepastId;
            updatedValue.UserId = p.UserId;
            updatedValue.Date = p.Date;
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Gets meal by given user Id.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <returns></returns>
        public List<Meal> GetMealbyUserId(int userId,DateTime minDate,DateTime maxDate)
        {
            return c.Meals.Where(a => a.UserId == userId && a.Date>=minDate && a.Date <=maxDate).ToList();
        }
        /// <summary>
        /// Gets all meals which had added by given user. 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Meal> GetMealbyUserId(int userId)
        {
            return c.Meals.Where(a => a.UserId == userId ).ToList();
        }
        /// <summary>
        /// Gets meal for current day.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Meal> GetTodaysMealbyUserId(int userId)
        {
            return c.Meals.Where(a => a.UserId == userId && a.Date.Day ==DateTime.Now.Day).ToList();
        }
    }
}
