using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class AboutMeMap : IEntityTypeConfiguration<AboutMe>
    {
        public void Configure(EntityTypeBuilder<AboutMe> builder)
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
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(25);
            builder.Property(x => x.ImagePath).IsRequired();
            builder.Property(x => x.ImagePath).HasMaxLength(250);
            builder.Property(x => x.MyJob).IsRequired();
            builder.Property(x => x.MyJob).HasMaxLength(60);
            builder.Property(x => x.MyJobFA).IsRequired();
            builder.Property(x => x.MyJobFA).HasMaxLength(150);
            builder.Property(x => x.MyCVPath).IsRequired();
            builder.Property(x => x.MyCVPath).HasMaxLength(250);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.ToTable("AboutMe");
            builder.HasData(new AboutMe
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                FirstName = "Atahan",
                LastName = "Öztürk",
                ImagePath = "",
                MyJob = "Web Developer",
                MyJobFA = "<i class=\"fas fa - laptop - code\"></i>",
                MyCVPath = "",
                BirthDate = DateTime.Parse("20.06.1994")
            });
            ;
        }
    }
}
