using StayFitNTier.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StayFitNTier.Model.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
            //Meals = new HashSet<Meal>();
            MealDetails=new HashSet<MealDetail>();
        }
        public int Portion { get; set; } = 1;
        public decimal Calories { get; set; }
        public decimal Protein { get; set; }
        public decimal HealthIndex { get; set; } = 1;
        public decimal PortionWeight { get; set; } = 100;        
        public int SubCategoryId { get; set; }
        public bool IsActive { get; set; } = true;
        public byte[] Photo { get; set; }
        public SubCategory SubCategory { get; set; }
        //public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<MealDetail> MealDetails { get; set; }
    }
}
