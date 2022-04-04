using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.EntityConfiguration
{
    public class MealDetailConfiguration : EntityTypeConfiguration<MealDetail>
    {
        public MealDetailConfiguration()
        {

            HasKey(a => new { a.ProductId, a.MealId });
            
            

        }
    }
}
