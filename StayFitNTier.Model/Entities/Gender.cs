using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.Model.Entities
{
    public class Gender
    {
        public Gender()
        {
            UserProperties = new HashSet<UserProperty>();
        }
        public int Id { get; set; }
        public string GenderType { get; set; }
       
        public virtual ICollection<UserProperty> UserProperties { get; set; }
    }
}
