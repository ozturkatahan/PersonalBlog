using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalBlog.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutMe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MyJob = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    MyJobFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MyCVPath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutMe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SecurityQuestion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SQAnswer = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortAdress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePageSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LogoText = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LogoFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteIdentity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PercentageValue = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AccountFA = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    AccountURL = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AboutMe",
                columns: new[] { "Id", "BirthDate", "CreatedByName", "CreatedTime", "FirstName", "ImagePath", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedTime", "MyCVPath", "MyJob", "MyJobFA" },
                values: new object[] { 1, new DateTime(1994, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 27, 49, DateTimeKind.Local).AddTicks(9857), "Atahan", "", false, false, "Öztürk", "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 27, 49, DateTimeKind.Local).AddTicks(9861), "", "Web Developer", "<i class=\"fas fa - laptop - code\"></i>" });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Email", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Password", "SQAnswer", "SecurityQuestion" },
                values: new object[] { 1, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 27, 65, DateTimeKind.Local).AddTicks(3855), "ozturkatahan5@gmail.com", false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 27, 65, DateTimeKind.Local).AddTicks(3857), " 202cb962ac59075b964b07152d234b70", "94f80647bdc6e286c8af93d0852b62ce", "Ilk Evcil Hayvan" });

            migrationBuilder.InsertData(
                table: "ContactInfo",
                columns: new[] { "Id", "Adress", "CreatedByName", "CreatedTime", "Email", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "PhoneNumber", "ShortAdress" },
                values: new object[] { 1, "Atakule Çankaya - ANKARA", "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 964, DateTimeKind.Local).AddTicks(6625), "ozturkatahan5@gmail.com", false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 964, DateTimeKind.Local).AddTicks(6629), "+90 539 301 87 50", "Çankaya - ANKARA" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Description", "Duration", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "SchoolName", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 956, DateTimeKind.Local).AddTicks(7200), "Tez aşamasında.", "Şubat 2019 - Devam Ediyor", false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 956, DateTimeKind.Local).AddTicks(7204), "Ankara Yıldırım Beyazıt Üniversitesi - Bilgisayar Mühendisliği", "Yüksek Lisans Derecesi (Tezli)" },
                    { 2, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 957, DateTimeKind.Local).AddTicks(3483), "aaa", "Eylül 2013 - Haziran 2018", false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 957, DateTimeKind.Local).AddTicks(3486), "Ankara Yıldırım Beyazıt Üniversitesi - Bilgisayar Mühendisliği", "Lisans Derecesi" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Description", "Duration", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Title", "WorkPlace" },
                values: new object[] { 1, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 947, DateTimeKind.Local).AddTicks(9985), "İşkur destekli, eğitim sonunda sertifika aldığım web geliştiricisi kursu.", "Ağustos 2020 - Ocak 2021", false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 947, DateTimeKind.Local).AddTicks(9988), "ASP.NET and ASP.NET Core Web Geliştiricisi Kursiyeri (İşkur Destekli)", "Bilge Adam Akademi" });

            migrationBuilder.InsertData(
                table: "HomePageSliders",
                columns: new[] { "Id", "Content", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "ShortContent", "Title" },
                values: new object[] { 1, "", "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 938, DateTimeKind.Local).AddTicks(8370), false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 938, DateTimeKind.Local).AddTicks(8373), "Web geliştirici ...", "Web Geliştirici" });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Text" },
                values: new object[,]
                {
                    { 1, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 896, DateTimeKind.Local).AddTicks(4037), false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 896, DateTimeKind.Local).AddTicks(4055), "Web Uygulama Geliştirme, Mobil Uygulama Geliştirme, Mobil Oyun Geliştirme" },
                    { 2, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 896, DateTimeKind.Local).AddTicks(6651), false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 896, DateTimeKind.Local).AddTicks(6654), "Bilimsel Makaleler, Yapay Zeka, Blockchain" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedTime", "Subject", "Text" },
                values: new object[] { 1, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 929, DateTimeKind.Local).AddTicks(8946), "deneme@gmail.com", "Atahan", false, false, "Öztürk", "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 929, DateTimeKind.Local).AddTicks(8950), "Deneme", "Deneme Yazısı" });

            migrationBuilder.InsertData(
                table: "SiteIdentity",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Description", "IsActive", "IsDeleted", "Keywords", "LogoFA", "LogoText", "ModifiedByName", "ModifiedTime", "Title" },
                values: new object[] { 1, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 921, DateTimeKind.Local).AddTicks(7303), "Atahan Öztürk Web Developer", false, false, "C#, .NET, .NET Core, Web, Software", "<i class=\"fab fa - connectdevelop\"></i>", "Atahan Öztürk", "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 921, DateTimeKind.Local).AddTicks(7311), "Atahan Öztürk" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "PercentageValue", "Title" },
                values: new object[] { 1, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 910, DateTimeKind.Local).AddTicks(9544), false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 910, DateTimeKind.Local).AddTicks(9547), 75, "C#" });

            migrationBuilder.InsertData(
                table: "SocialMediaAccounts",
                columns: new[] { "Id", "Account", "AccountFA", "AccountURL", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime" },
                values: new object[] { 1, "Linkedin", "<i class=\"fab fa - linkedin\"></i>", "https://www.linkedin.com/in/atahan-öztürk-43599b131/", "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 903, DateTimeKind.Local).AddTicks(4047), false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 903, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.InsertData(
                table: "Summary",
                columns: new[] { "Id", "Content", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime" },
                values: new object[] { 1, "Ankara Yıldırım Beyazıt Üniversitesi'nden Haziran 2018'de mezun oldum. Lisansım esnasında bir tanesi ASP.NET ile web uygulaması geliştirme diğeri ise Xamarin ile mobil uygulama geliştirme üzerine olmak üzere 2 staj yaptım. Mezun olduktan sonra BiSoft Bilgi Teknolojilerinde 2 haftalık Web temelli Java eğitimi aldım. Arkasından Unity 3D ile mobil tabanlı bir oyun geliştirdim ve Google Play Store’da yayınladım. Şubat 2019'da ise Ankara Yıldırım Beyazıt Üniversitesi'nde yüksek lisansa başladım. Ağustos 2019'da İşkur Nitelikli Bilişim Uzmanı Yetiştirme Programı kapsamında Bilge Adam Akademi'de ASP.NET Web Programlama kursuna katıldım (Ağustos 2019 - Ocak 2020). Kurs bittiğinden bu yana; ASP.NET, ASP.NET Core, Javascript, Angular, NodeJS gibi teknolojileri takiben web uygulaması geliştirmeye devam ediyorum.", "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 885, DateTimeKind.Local).AddTicks(499), false, false, "InitialCreated", new DateTime(2021, 3, 23, 20, 25, 26, 885, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutMe");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "HomePageSliders");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "SiteIdentity");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SocialMediaAccounts");

            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
