using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.EntityConfiguration
{
    class PhysicalActivityConfiguration : EntityTypeConfiguration<PhysicalActivity>
    {
        public PhysicalActivityConfiguration()
        {
            Property(a => a.Description).IsRequired().HasMaxLength(200);
            Property(a => a.Name).IsRequired().HasMaxLength(10);
            HasMany(a => a.UserProperties).WithRequired(a => a.PhysicalActivity).HasForeignKey(a => a.PhysicalActivityId);


        }
    }
}
