using StayFitNTier.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.Model.Entities
{
    public class Repast : BaseEntity
    {
        public Repast()
        {
            Meals = new HashSet<Meal>();
        }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
