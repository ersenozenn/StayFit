using StayFitNTier.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.Model.Entities
{
    public class Category:BaseEntity
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
        public bool IsActive { get; set; } = true;
        public byte[] Photo { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
        
    }
}
