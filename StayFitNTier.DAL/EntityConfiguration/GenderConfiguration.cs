using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.EntityConfiguration
{
    class GenderConfiguration : EntityTypeConfiguration<Gender>
    {
        public GenderConfiguration()
        {
            Property(a => a.GenderType).IsRequired().HasMaxLength(10);
            HasMany(a => a.UserProperties).WithRequired(a => a.Gender).HasForeignKey(a => a.GenderId);
        }
    }
}
