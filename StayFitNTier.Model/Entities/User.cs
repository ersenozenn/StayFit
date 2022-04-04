using StayFitNTier.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.Model.Entities
{
    public class User 
    {
        public User()
        {
            Meals = new HashSet<Meal>();
            UserProperties = new HashSet<UserProperty>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; } = "Değer girilmedi";
        public string Mail { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + Surname;
            }
        }

        public bool IsActive { get; set; } = true;
        public string Password { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;       
        
        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<UserProperty> UserProperties { get; set; }
    }
}
