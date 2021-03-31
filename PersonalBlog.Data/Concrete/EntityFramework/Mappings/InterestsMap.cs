using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class InterestsMap : IEntityTypeConfiguration<Interests>
    {
        public void Configure(EntityTypeBuilder<Interests> builder)
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
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.Text).HasMaxLength(300);
            builder.ToTable("Interests");
            builder.HasData(new Interests
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Text = "Web Uygulama Geliştirme, Mobil Uygulama Geliştirme, Mobil Oyun Geliştirme"
            }, new Interests
            {
                Id = 2,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Text = "Bilimsel Makaleler, Yapay Zeka, Blockchain"
            });
            ;
        }
    }
}
