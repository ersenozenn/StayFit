using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.Model.Entities
{
    public class MealDetail
    {
        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual int MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public int PortionforMeal { get; set; } = 1;
        public decimal CaloriesforMeal { get; set; }
        public decimal ProteinforMeal { get; set; }
        public decimal HealthIndexforMeal { get; set; }
        public decimal PortionWeightforMeal { get; set; } = 100;
        
    }
}
