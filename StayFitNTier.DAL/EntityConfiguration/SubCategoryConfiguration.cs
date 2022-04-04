using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.EntityConfiguration
{
    class SubCategoryConfiguration : EntityTypeConfiguration<SubCategory>
    {
        public SubCategoryConfiguration()
        {
            Property(a => a.Name).IsRequired().HasMaxLength(70);
            HasRequired(a => a.Category).WithMany(a => a.SubCategories).HasForeignKey(a => a.CategoryId);
            
        }
    }
}
