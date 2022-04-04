using StayFitNTier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFitNTier.DAL.EntityConfiguration
{
    class RepastConfiguration : EntityTypeConfiguration<Repast>
    {
        public RepastConfiguration()
        {
            Property(a => a.Name).IsRequired().HasMaxLength(10);
        }
    }
}
