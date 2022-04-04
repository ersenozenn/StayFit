using StayFitNTier.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.Model.Entities
{
    public class SubCategory:BaseEntity 

    {
        public SubCategory()
        {
            Products = new HashSet<Product>();
        }        
        public int CategoryId { get; set; }
        public bool IsActive { get; set; } = true;
        public byte[] Photo { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
