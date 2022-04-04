using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.EntityConfiguration
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(a => a.FirstName).IsRequired().HasMaxLength(25);
            Property(a => a.Surname).IsRequired().HasMaxLength(25);
            Property(a => a.PhoneNumber).HasMaxLength(15);
            Property(a => a.Mail).IsRequired().HasMaxLength(25);
            
            

            HasMany(a => a.Meals).WithRequired(a => a.User).HasForeignKey(a => a.UserId);
        }

    }
}
