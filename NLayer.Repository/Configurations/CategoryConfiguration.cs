using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    // entity'e pk, nvarchar(30) gibi şeyler eklemek icin
    // category'nin fluent api kısmını burada
    //IEntityTypeConfiguration ile yapacağız
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // haskey ile pk yaptık
            builder.HasKey(x => x.Id);

            // birer birer Id artsın
            builder.Property(x => x.Id).UseIdentityColumn();

            //name alanı max 50 karakter olsun
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.ToTable("Categories");
        }
    }
}
