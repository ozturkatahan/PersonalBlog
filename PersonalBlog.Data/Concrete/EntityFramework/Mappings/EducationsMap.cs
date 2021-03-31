using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class EducationsMap : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
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
            builder.Property(x => x.SchoolName).IsRequired();
            builder.Property(x => x.SchoolName).HasMaxLength(150);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Duration).HasMaxLength(30);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.ToTable("Educations");
            builder.HasData(new Education
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Title = "Yüksek Lisans Derecesi (Tezli)",
                SchoolName = "Ankara Yıldırım Beyazıt Üniversitesi - Bilgisayar Mühendisliği",
                Duration = "Şubat 2019 - Devam Ediyor",
                Description = "Tez aşamasında."
            },
            new Education
            {
                Id = 2,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Title = "Lisans Derecesi",
                SchoolName = "Ankara Yıldırım Beyazıt Üniversitesi - Bilgisayar Mühendisliği",
                Duration = "Eylül 2013 - Haziran 2018",
                Description = "aaa"
            }
            );
        }
    }
}
