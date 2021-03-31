using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class SkillsMap : IEntityTypeConfiguration<Skills>
    {
        public void Configure(EntityTypeBuilder<Skills> builder)
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
            builder.Property(x => x.Title).HasMaxLength(25);
            builder.Property(x => x.PercentageValue).IsRequired();
            builder.ToTable("Skills");
            builder.HasData(new Skills
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Title = "C#",
                PercentageValue = 75
            });
            ;
            ;
        }
    }
}
