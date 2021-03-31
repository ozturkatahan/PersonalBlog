using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog.Data.Concrete.EntityFramework.Mappings
{
    public class SummaryMap : IEntityTypeConfiguration<Summary>
    {
        public void Configure(EntityTypeBuilder<Summary> builder)
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
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("Summary");
            // Veritabanı ilk oluştuğunda eklenmesini istediğimiz içerikler
            builder.HasData(new Summary { 
                Id = 1, 
                CreatedByName = "InitialCreated",
                ModifiedByName = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDeleted = false,
                Content = "Ankara Yıldırım Beyazıt Üniversitesi'nden Haziran 2018'de mezun oldum. " +
                "Lisansım esnasında bir tanesi ASP.NET ile web uygulaması geliştirme diğeri ise Xamarin ile " +
                "mobil uygulama geliştirme üzerine olmak üzere 2 staj yaptım. Mezun olduktan sonra BiSoft Bilgi " +
                "Teknolojilerinde 2 haftalık Web temelli Java eğitimi aldım. Arkasından Unity 3D ile mobil tabanlı " +
                "bir oyun geliştirdim ve Google Play Store’da yayınladım. Şubat 2019'da ise " +
                "Ankara Yıldırım Beyazıt Üniversitesi'nde yüksek lisansa başladım. Ağustos 2019'da " +
                "İşkur Nitelikli Bilişim Uzmanı Yetiştirme Programı kapsamında Bilge Adam Akademi'de ASP.NET " +
                "Web Programlama kursuna katıldım (Ağustos 2019 - Ocak 2020). " +
                "Kurs bittiğinden bu yana; ASP.NET, ASP.NET Core, Javascript, Angular, NodeJS gibi teknolojileri " +
                "takiben web uygulaması geliştirmeye devam ediyorum."
            });

        }
    }
}
