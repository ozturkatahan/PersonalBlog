using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticlesMap : IEntityTypeConfiguration<Articles>
    {
        public void Configure(EntityTypeBuilder<Articles> builder)
        {
            // Id'yi primary yap
            builder.HasKey(x => x.Id);
            // Id'yi 1er artır
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.Thumbnail).IsRequired();
            builder.Property(x => x.Thumbnail).HasMaxLength(250);
            builder.Property(x => x.ViewsCount).IsRequired();
            builder.Property(x => x.SeoTags).IsRequired();
            builder.Property(x => x.SeoTags).HasMaxLength(150);
            builder.Property(x => x.SeoDescription).IsRequired();
            builder.Property(x => x.SeoDescription).HasMaxLength(150);
            builder.Property(x => x.ShortContent).IsRequired();
            builder.Property(x => x.ShortContent).HasMaxLength(500);
            // Categoriden articlellara one to many ilişki
            builder.HasOne<Categories>(x => x.Categories).WithMany(x => x.Articles).HasForeignKey(x => x.CategoryId);
            builder.ToTable("Articles");
        }
    }
}
