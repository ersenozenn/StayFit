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
    public class MealDetailRepository : BaseRepository<MealDetail>, IDeleteforAdmin<MealDetail>
    {
        StayFitDbContext c;
        public MealDetailRepository()
        {
            c = new StayFitDbContext();
        }
        /// <summary>
        /// Returns a list which contains MealDetails for one meal.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public List<MealDetail> GetMealDetailsforOneMeal(int mealId)
        {
            return c.MealDetails.Where(a => a.MealId == mealId).ToList();
            
        }
        /// <summary>
        /// Returns a list which contains MealDetails for one meal.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public List<Product> GetProductsforOneMeal(int mealId)
        {
            var list = c.MealDetails.Where(a => a.MealId == mealId).ToList();
            List<Product> products = new List<Product>();
            foreach (var item in list)
            {
                Product product = c.Products.Find(item.ProductId);
                products.Add(product);
            }
            return products;

        }
        /// <summary>
        /// Returns a list which contains Meals for one product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public List<Meal> GetMealsforOneProduct(int productId)
        {
            var list=c.MealDetails.Where(a => a.ProductId == productId).ToList();
            List<Meal> meals = new List<Meal>();
            foreach (var item in list)
            {
                Meal meal = c.Meals.Find(item.MealId);
                meals.Add(meal);
            }
            return meals;
        }
        /// <summary>
        /// Get one meal property with mealId
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public Meal GetMealsbyMealId(int mealId)
        {
            var list = c.MealDetails.Where(a => a.MealId == mealId).FirstOrDefault();
            if (list == null) return null;
            else return c.Meals.Find(list.MealId);
        }

        /// <summary>
        /// Lists the 5 most preferred category and count Id by all users in the given date range.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredCategoriesbyDate(DateTime minValue,DateTime maxValue)
        {
            var list = c.MealDetails.Join(c.Meals, md => md.MealId, p => p.Id, (md, p) => new { p.UserId, md.ProductId, p.Date }).Join(c.Products, md => md.ProductId, p => p.Id, (md, p) => new { p.SubCategoryId, md.ProductId, md.UserId, md.Date }).Join(c.SubCategories, p => p.SubCategoryId, s => s.Id, (p, s) => new { p.SubCategoryId, s.CategoryId, p.UserId, p.Date }).Join(c.Categories, p => p.CategoryId, s => s.Id, (p, s) => new
            {
                p.SubCategoryId,
                s.Id,
                p.UserId,
                p.Date
            }).Where(a =>  a.Date >= minValue && a.Date <= maxValue).GroupBy(a => a.Id).Select(group => new { ID = group.Key, Count = group.Count() }).OrderByDescending(b => b.Count).Take(5).ToList();

            Dictionary<int, int> categories = new Dictionary<int, int>();
            foreach (var item in list)
            {
                
                categories.Add(item.ID, item.Count);
            }
            return categories;
        }

        /// <summary>
        /// Lists the 5 most preferred category and count Id by all users and within the given date range in the given date range.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredCategoriesbyUseranDate1(int userId, DateTime minDate, DateTime maxDate)
        {
            var list = c.MealDetails.Join(c.Meals, md => md.MealId, p => p.Id, (md, p) => new { p.UserId, md.ProductId, p.Date, p.RepastId }).Join(c.Products, md => md.ProductId, p => p.Id, (md, p) => new { p.SubCategoryId, md.ProductId, md.UserId, md.Date, md.RepastId }).Join(c.SubCategories, p => p.SubCategoryId, s => s.Id, (p, s) => new { p.SubCategoryId, s.CategoryId, p.UserId, p.Date, p.RepastId }).Join(c.Categories, p => p.CategoryId, s => s.Id, (p, s) => new
            {
                p.SubCategoryId,
                s.Id,
                p.UserId,
                p.Date,
                p.RepastId
            }).Where(a => a.UserId == userId && a.Date >= minDate && a.Date <= maxDate ).GroupBy(a => a.Id).Select(group => new { ID = group.Key, Count = group.Count() }).OrderByDescending(b => b.Count).Take(5).ToList();

            Dictionary<int, int> categories = new Dictionary<int, int>();
            foreach (var item in list)
            {                
                categories.Add(item.ID, item.Count);
            }
            return categories;
        }
        /// <summary>
        /// Lists the 5 most preferred category and count Id by all users and within the given date range also with repast Id in the given date range.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredCategoriesbyUser(int userId, DateTime minDate, DateTime maxDate,int repastId)
        {
            var list = c.MealDetails.Join(c.Meals, md => md.MealId, p => p.Id, (md, p) => new { p.UserId, md.ProductId, p.Date,p.RepastId }).Join(c.Products, md => md.ProductId, p => p.Id, (md, p) => new { p.SubCategoryId, md.ProductId, md.UserId, md.Date,md.RepastId }).Join(c.SubCategories, p => p.SubCategoryId, s => s.Id, (p, s) => new { p.SubCategoryId, s.CategoryId, p.UserId, p.Date,p.RepastId }).Join(c.Categories, p => p.CategoryId, s => s.Id, (p, s) => new
            {
                p.SubCategoryId,
                s.Id,
                p.UserId,
                p.Date,
                p.RepastId
            }).Where(a => a.UserId == userId && a.Date >= minDate && a.Date <= maxDate && a.RepastId==repastId).GroupBy(a => a.Id).Select(group => new { ID = group.Key, Count = group.Count() }).OrderByDescending(b => b.Count).Take(5).ToList();

            Dictionary<int, int> categories = new Dictionary<int, int>();
            foreach (var item in list)
            {                
                categories.Add(item.ID, item.Count);
            }
            return categories;
        }
        /// <summary>
        /// Lists the 5 most preferred category Id and count by all users and within the given date range also with repast Id in the given date.
        /// </summary>
        /// <param name="minDate"></param>
        /// <param name="maxDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredCategoriesforGeneralbyRepast(DateTime minDate, DateTime maxDate, int repastId)
        {
            var list = c.MealDetails.Join(c.Meals, md => md.MealId, p => p.Id, (md, p) => new { p.UserId, md.ProductId, p.Date, p.RepastId }).Join(c.Products, md => md.ProductId, p => p.Id, (md, p) => new { p.SubCategoryId, md.ProductId, md.UserId, md.Date, md.RepastId }).Join(c.SubCategories, p => p.SubCategoryId, s => s.Id, (p, s) => new { p.SubCategoryId, s.CategoryId, p.UserId, p.Date, p.RepastId }).Join(c.Categories, p => p.CategoryId, s => s.Id, (p, s) => new
            {
                p.SubCategoryId,
                s.Id,
                p.UserId,
                p.Date,
                p.RepastId
            }).Where(a =>  a.Date >= minDate && a.Date <= maxDate && a.RepastId == repastId).GroupBy(a => a.Id).Select(group => new { ID = group.Key, Count = group.Count() }).OrderByDescending(b => b.Count).Take(5).ToList();

            Dictionary<int, int> categories = new Dictionary<int, int>();
            foreach (var item in list)
            {                
                categories.Add(item.ID, item.Count);
            }
            return categories;
        }
        /// <summary>
        /// Lists the 5 most preferred product Id and count by repast.
        /// </summary>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredProductsbyRepast(int repastId)
        {
            var list = c.MealDetails.Join(c.Meals, md => md.MealId, p => p.Id, (md, p) => new { p.UserId, md.ProductId, p.Date, p.RepastId }).GroupBy(a => a.ProductId).Select(group => new { ID = group.Key, Count = group.Count(a=>a.RepastId== repastId) }).OrderByDescending(b => b.Count).Take(5).ToList();

            Dictionary<int, int> products = new Dictionary<int, int>();
            foreach (var item in list)
            {                
                products.Add(item.ID, item.Count);
            }
            return products;
        }
        /// <summary>
        /// Lists the 5 most preferred product Id and count by user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredProductsbyUser(int userId)
        {
            var list = c.MealDetails.Join(c.Meals, md => md.MealId, m => m.Id, (md, m) => new { m.UserId, md.ProductId }).Where(a => a.UserId == userId).GroupBy(a => a.ProductId).Select(group => new { ID = group.Key, Count = group.Count() }).OrderByDescending(b => b.Count).Take(5).ToList();

            Dictionary<int, int> products = new Dictionary<int, int>();
            foreach (var item in list)
            {                
                products.Add(item.ID, item.Count);
            }
            return products;
        }
        /// <summary>
        /// Returns most preferred products by all user.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, int> GetMostPreferredProducts()
        {
            var list = c.MealDetails.Join(c.Meals, md => md.MealId, m => m.Id, (md, m) => new { m.UserId, md.ProductId }).GroupBy(a => a.ProductId).Select(group => new { ID = group.Key, Count = group.Count() }).OrderByDescending(b => b.Count).Take(5).ToList();

            Dictionary<int, int> products = new Dictionary<int, int>();
            foreach (var item in list)
            {
                products.Add(item.ID, item.Count);
            }
            return products;
        }
        /// <summary>
        /// Calculates total calory by user within the given date range.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <returns></returns>
        public decimal GetCaloriesbyTime(int userId, DateTime minMealDate, DateTime maxMealDate)
        {
            return c.MealDetails.Join(c.Meals, md => md.MealId, m => m.Id, (md, m) => new { m.UserId, md.ProductId, m.Date, md.CaloriesforMeal }).Where(a => a.UserId == userId && a.Date >= minMealDate && a.Date <= maxMealDate).Sum(a => a.CaloriesforMeal);
        }
        /// <summary>
        /// Calculates total protein by user within the given date range.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <returns></returns>
        public decimal GetProteinbyTime(int userId, DateTime minMealDate, DateTime maxMealDate)
        {
            return c.MealDetails.Join(c.Meals, md => md.MealId, m => m.Id, (md, m) => new { m.UserId, md.ProductId, m.Date, md.ProteinforMeal }).Where(a => a.UserId == userId && a.Date >= minMealDate && a.Date <= maxMealDate).Sum(a => a.ProteinforMeal);
        }
        /// <summary>
        /// Calculates average helath index by user within the given date range.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <returns></returns>
        public decimal GetHealthIndexbyTime(int userId, DateTime minMealDate, DateTime maxMealDate)
        {

            return (c.MealDetails.Join(c.Meals, md => md.MealId, m => m.Id, (md, m) => new { m.UserId, md.ProductId, m.Date, md.HealthIndexforMeal }).Where(a => a.UserId == userId && a.Date >= minMealDate && a.Date <= maxMealDate).Average(a => a.HealthIndexforMeal));

        }
        /// <summary>
        /// Calculates total calory by user and repast within the given date range.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public decimal GetCaloriesbyRepast(int userId, DateTime minMealDate, DateTime maxMealDate, int repastId)
        {
            return c.MealDetails.Join(c.Meals, md => md.MealId, m => m.Id, (md, m) => new { m.UserId, md.ProductId, m.Date, md.CaloriesforMeal, m.RepastId }).Where(a => a.UserId == userId && a.Date >= minMealDate && a.Date <= maxMealDate && a.RepastId == repastId).Sum(a => a.CaloriesforMeal);
        }
        /// <summary>
        /// Calculates total protein by user and repast within the given date range.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public decimal GetProteinbyRepast(int userId, DateTime minMealDate, DateTime maxMealDate, int repastId)
        {
            return c.MealDetails.Join(c.Meals, md => md.MealId, m => m.Id, (md, m) => new { m.UserId, md.ProductId, m.Date, md.ProteinforMeal, m.RepastId }).Where(a => a.UserId == userId && a.Date >= minMealDate && a.Date <= maxMealDate && a.RepastId == repastId).Sum(a => a.ProteinforMeal);
        }
        /// <summary>
        /// Calculate average healt index by user and repast within the given date range.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="minMealDate"></param>
        /// <param name="maxMealDate"></param>
        /// <param name="repastId"></param>
        /// <returns></returns>
        public decimal GetHealthIndexbyRepast(int userId, DateTime minMealDate, DateTime maxMealDate, int repastId)
        {
            return c.MealDetails.Join(c.Meals, md => md.MealId, m => m.Id, (md, m) => new { m.UserId, md.ProductId, m.Date, md.HealthIndexforMeal, m.RepastId }).Where(a => a.UserId == userId && a.Date >= minMealDate && a.Date <= maxMealDate && a.RepastId == repastId).Average(a => a.HealthIndexforMeal);
        }
        /// <summary>
        /// Gets meal detail property with mealId and productId.
        /// </summary>
        /// <param name="mealId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public MealDetail GetbyKeys(int mealId,int productId)
        {
            return c.MealDetails.Where(md => md.MealId == mealId && md.ProductId == productId).SingleOrDefault();
        }
        /// <summary>
        /// Deletes meal detail row for meal detail sent.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteforAdmin(MealDetail p)
        {
            MealDetail deletedValue = c.MealDetails.SingleOrDefault(a => a.MealId == p.MealId && a.ProductId == p.ProductId);
            c.MealDetails.Remove(deletedValue);
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Updates meal detail row for meal detail sent.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool UpdateforAdmin(MealDetail p)
        {
            MealDetail updatedValue = c.MealDetails.SingleOrDefault(a => a.MealId == p.MealId && a.ProductId == p.ProductId);
            updatedValue = p;
            return c.SaveChanges() > 0;
        }
        /// <summary>
        /// Gets total calory within meal Id.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public decimal GetCaloriesforOneMeal(int mealId)
        {
            return c.MealDetails.Where(a => a.MealId==mealId).Sum(a => a.CaloriesforMeal);
        }
        /// <summary>
        /// Gets total calory within meal Id.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public decimal GetProteinforOneMeal(int mealId)
        {
            return c.MealDetails.Where(a => a.MealId == mealId).Sum(a => a.ProteinforMeal);
        }
    }
}
