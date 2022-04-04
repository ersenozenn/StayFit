using StayFitNTier.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.Model.Entities
{
    public class Meal:BaseEntity
    {
        public Meal()
        {            
            //Products = new HashSet<Product>();
            MealDetails = new HashSet<MealDetail>();
        }
        public DateTime Date { get; set; } = DateTime.Now;
        public int RepastId { get; set; }
        public Repast Repast { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }        

        //public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<MealDetail> MealDetails { get; set; }


    }
}
