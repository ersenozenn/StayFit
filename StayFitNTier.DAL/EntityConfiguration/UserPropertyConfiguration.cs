using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.EntityConfiguration
{
    class UserPropertyConfiguration : EntityTypeConfiguration<UserProperty>
    {
        public UserPropertyConfiguration()
        {       
            Property(u => u.Height).IsRequired();
            Property(u => u.Weight).IsRequired();
            Property(u => u.BirthDate).IsRequired();            
            HasRequired(a => a.User).WithMany(a => a.UserProperties).HasForeignKey(a => a.UserId);
        }
    }
}
