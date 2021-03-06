// <auto-generated />
using System;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogApp.Data.Migrations
{
    [DbContext(typeof(BlogAppContext))]
    [Migration("20220225005757_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogApp.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentsCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentsCount = 1,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 590, DateTimeKind.Local).AddTicks(6524),
                            Date = new DateTime(2022, 2, 25, 3, 57, 56, 590, DateTimeKind.Local).AddTicks(5441),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 590, DateTimeKind.Local).AddTicks(7081),
                            Note = "C# Blog Kategorisi",
                            SeoAuthor = "Yasin Durgun",
                            SeoDescription = "C# 9.0 ve .NET5 Yenilikleri",
                            SeoTags = "C#, C# 9, .NET5, .NET CORE, .NET Framework",
                            Thumbnail = "Default.jpeg",
                            Title = "C# 9.0 ve .NET5 Yenilikleri",
                            UserId = 1,
                            ViewsCount = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentsCount = 1,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 590, DateTimeKind.Local).AddTicks(8376),
                            Date = new DateTime(2022, 2, 25, 3, 57, 56, 590, DateTimeKind.Local).AddTicks(8374),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 590, DateTimeKind.Local).AddTicks(8377),
                            Note = "C++ Blog Kategorisi",
                            SeoAuthor = "Yasin Durgun",
                            SeoDescription = "C++ 11 Yenilikleri",
                            SeoTags = "C++, C++11, C++19",
                            Thumbnail = "Default.jpeg",
                            Title = "C++ 11 Yenilikleri",
                            UserId = 1,
                            ViewsCount = 295
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentsCount = 1,
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 590, DateTimeKind.Local).AddTicks(8384),
                            Date = new DateTime(2022, 2, 25, 3, 57, 56, 590, DateTimeKind.Local).AddTicks(8383),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 590, DateTimeKind.Local).AddTicks(8386),
                            Note = "JavaScript Blog Kategorisi",
                            SeoAuthor = "Yasin Durgun",
                            SeoDescription = "JavaScript ES2021 VE ES2022 Yenilikleri",
                            SeoTags = "JS, ES",
                            Thumbnail = "Default.jpeg",
                            Title = "JavaScript ES2021 VE ES2022 Yenilikleri",
                            UserId = 1,
                            ViewsCount = 12
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "C#",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 593, DateTimeKind.Local).AddTicks(6852),
                            Description = "C# Programlama dili ile ilgili en güncel bilgileir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 593, DateTimeKind.Local).AddTicks(6863),
                            Note = "C# Blog Kategorisi"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "C++",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 593, DateTimeKind.Local).AddTicks(6879),
                            Description = "C++ Programlama dili ile ilgili en güncel bilgileir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 593, DateTimeKind.Local).AddTicks(6880),
                            Note = "C++ Blog Kategorisi"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "JavaScript",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 593, DateTimeKind.Local).AddTicks(6885),
                            Description = "JavaScript Programlama dili ile ilgili en güncel bilgileir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 593, DateTimeKind.Local).AddTicks(6886),
                            Note = "JavaScript Blog Kategorisi"
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 595, DateTimeKind.Local).AddTicks(7007),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 595, DateTimeKind.Local).AddTicks(7018),
                            Note = "C# Makale Yorumu",
                            Text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)."
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 595, DateTimeKind.Local).AddTicks(7034),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 595, DateTimeKind.Local).AddTicks(7035),
                            Note = "C++ Makale Yorumu",
                            Text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)."
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 595, DateTimeKind.Local).AddTicks(7040),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 595, DateTimeKind.Local).AddTicks(7041),
                            Note = "JavaScript Makale Yorumu",
                            Text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)."
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 597, DateTimeKind.Local).AddTicks(5671),
                            Description = "Admin Rolü tüm haklara sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "İnitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 597, DateTimeKind.Local).AddTicks(5684),
                            Name = "Admin",
                            Note = "Admin Rolüdür"
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 2, 25, 3, 57, 56, 609, DateTimeKind.Local).AddTicks(9564),
                            Description = "İlk Admin Kullanıcısı",
                            Email = "yasin.durgun52@gmail.com",
                            FirstName = "Yasin",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Durgun",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 2, 25, 3, 57, 56, 609, DateTimeKind.Local).AddTicks(9579),
                            Note = "Admin Kullanıcısı",
                            PasswordHash = new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 },
                            Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU",
                            RoleId = 1,
                            UserName = "Yasin Durgun"
                        });
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Article", b =>
                {
                    b.HasOne("BlogApp.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogApp.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("BlogApp.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.User", b =>
                {
                    b.HasOne("BlogApp.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BlogApp.Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
