﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {

        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            // haskey ile pk yaptık
            builder.HasKey(x => x.Id);

            // birer birer Id artsın
            builder.Property(x => x.Id).UseIdentityColumn();

            // bire bir ilişki icin
            builder.HasOne(x => x.Product).WithOne(x => x.ProductFeature).HasForeignKey<ProductFeature>(x => x.ProductId);
        }
    }
}
