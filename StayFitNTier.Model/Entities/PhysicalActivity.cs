using StayFitNTier.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.Model.Entities
{
    public class PhysicalActivity:BaseEntity
    {
        public PhysicalActivity()
        {
            UserProperties = new HashSet<UserProperty>();
        }
        public string Description { get; set; }        
       
        public virtual ICollection<UserProperty> UserProperties { get; set; }
    }
}
