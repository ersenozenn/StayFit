using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.Model.Entities
{
    public class UserProperty
    {
        public UserProperty()
        {
            
        }

        public int Id { get; set; }

        public int Height { get; set; } //cm üzerinden hesap yapılacak.
        public decimal Weight { get; set; }
        public DateTime BirthDate { get; set; }
        
        public bool IsActive { get; set; }
        public byte[] Photo { get; set; }
        public int UserId { get; set; }
        public DateTime MeasarumentDate { get; set; } = DateTime.Now;
        public virtual User User { get; set; }

        public int PhysicalActivityId { get; set; }
        public PhysicalActivity PhysicalActivity { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        
        
    }
}
