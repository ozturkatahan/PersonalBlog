using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ExperiencesMap : IEntityTypeConfiguration<Experiences>
    {
        public void Configure(EntityTypeBuilder<Experiences> builder)
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
            builder.Property(x => x.Title).HasMaxLength(150);
            builder.Property(x => x.WorkPlace).IsRequired();
            builder.Property(x => x.WorkPlace).HasMaxLength(150);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Duration).HasMaxLength(150);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(300);
            builder.ToTable("Experiences");
            builder.HasData(new Experiences
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Title = "ASP.NET and ASP.NET Core Web Geliştiricisi Kursiyeri (İşkur Destekli)",
                WorkPlace = "Bilge Adam Akademi",
                Duration = "Ağustos 2020 - Ocak 2021",
                Description = "İşkur destekli, eğitim sonunda sertifika aldığım web geliştiricisi kursu."
            });
        }
    }
}
