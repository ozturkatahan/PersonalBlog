using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class SiteIdentityMap : IEntityTypeConfiguration<SiteIdentity>
    {
        public void Configure(EntityTypeBuilder<SiteIdentity> builder)
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
            builder.Property(x => x.Title).HasMaxLength(50);
            builder.Property(x => x.Keywords).IsRequired();
            builder.Property(x => x.Keywords).HasMaxLength(150);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(150);
            builder.Property(x => x.LogoFA).IsRequired();
            builder.Property(x => x.LogoFA).HasMaxLength(150);
            builder.Property(x => x.LogoText).IsRequired();
            builder.Property(x => x.LogoText).HasMaxLength(30);
            builder.ToTable("SiteIdentity");
            builder.HasData(new SiteIdentity
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Title = "Atahan Öztürk",
                Keywords = "C#, .NET, .NET Core, Web, Software",
                Description = "Atahan Öztürk Web Developer",
                LogoText = "Atahan Öztürk",
                LogoFA = "<i class=\"fab fa - connectdevelop\"></i>"    
            });
        }
    }
}
