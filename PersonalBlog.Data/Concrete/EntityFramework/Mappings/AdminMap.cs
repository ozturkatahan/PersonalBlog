using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class AdminMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
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
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(250);
            builder.Property(x => x.SecurityQuestion).IsRequired();
            builder.Property(x => x.SecurityQuestion).HasMaxLength(200);
            builder.Property(x => x.SQAnswer).IsRequired();
            builder.Property(x => x.SQAnswer).HasMaxLength(250);
            builder.ToTable("Admin");
            builder.HasData(new Admin
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Email = "ozturkatahan5@gmail.com",
                Password = " 202cb962ac59075b964b07152d234b70",
                SecurityQuestion = "Ilk Evcil Hayvan",
                SQAnswer = "94f80647bdc6e286c8af93d0852b62ce"
            });
        }
    }
}
