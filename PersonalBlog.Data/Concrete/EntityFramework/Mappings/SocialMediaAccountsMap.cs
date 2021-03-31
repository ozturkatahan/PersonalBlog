using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class SocialMediaAccountsMap : IEntityTypeConfiguration<SocialMediaAccounts>
    {
        public void Configure(EntityTypeBuilder<SocialMediaAccounts> builder)
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
            builder.Property(x => x.Account).IsRequired();
            builder.Property(x => x.Account).HasMaxLength(30);
            builder.Property(x => x.AccountFA).IsRequired();
            builder.Property(x => x.AccountFA).HasMaxLength(120);
            builder.Property(x => x.AccountURL).IsRequired();
            builder.Property(x => x.AccountURL).HasMaxLength(150);
            builder.ToTable("SocialMediaAccounts");
            builder.HasData(new SocialMediaAccounts
            {
                Id = 1,
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Account = "Linkedin",
                AccountFA = "<i class=\"fab fa - linkedin\"></i>",
                AccountURL = "https://www.linkedin.com/in/atahan-öztürk-43599b131/"

            });
            ;
        }
    }
}
