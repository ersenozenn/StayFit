using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.EntityConfiguration
{
    class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(a => a.Name).IsRequired().HasMaxLength(50);            
            
            Property(a => a.Calories).IsRequired();
            Property(a => a.Protein).IsRequired();
            Property(a => a.HealthIndex).IsRequired();
            
            

            HasRequired(a => a.SubCategory).WithMany(a => a.Products).HasForeignKey(a => a.SubCategoryId);


        }
    }
}
