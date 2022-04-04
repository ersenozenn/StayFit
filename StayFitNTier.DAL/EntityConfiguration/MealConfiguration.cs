using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.EntityConfiguration
{
    class MealConfiguration : EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            Property(a => a.Name).IsRequired().HasMaxLength(100);

            HasRequired(a => a.Repast).WithMany(a => a.Meals).HasForeignKey(a => a.RepastId);

        }

    }
}
