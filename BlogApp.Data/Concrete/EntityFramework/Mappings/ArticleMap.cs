using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id); // id alanını pk yapmış olduk.
            builder.Property(a => a.Id).ValueGeneratedOnAdd(); // auto increment
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentsCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.ToTable("Articles");
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);

            builder.HasData(
                new Article()
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "C# 9.0 ve .NET5 Yenilikleri",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the " +
                    "industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled " +
                    "it to make a type specimen book. It has survived not only five centuries, but also the leap into " +
                    "electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release " +
                    "of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus " +
                    "PageMaker including versions of Lorem Ipsum.",
                    Thumbnail = "Default.jpeg",
                    SeoDescription = "C# 9.0 ve .NET5 Yenilikleri",
                    SeoTags = "C#, C# 9, .NET5, .NET CORE, .NET Framework",
                    SeoAuthor = "Yasin Durgun",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# Blog Kategorisi",
                    UserId = 1,
                    ViewsCount = 100,
                    CommentsCount = 1,
                },
                new Article()
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "C++ 11 Yenilikleri",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the " +
                    "industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled " +
                    "it to make a type specimen book. It has survived not only five centuries, but also the leap into " +
                    "electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release " +
                    "of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus " +
                    "PageMaker including versions of Lorem Ipsum.",
                    Thumbnail = "Default.jpeg",
                    SeoDescription = "C++ 11 Yenilikleri",
                    SeoTags = "C++, C++11, C++19",
                    SeoAuthor = "Yasin Durgun",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C++ Blog Kategorisi",
                    UserId = 1,
                    ViewsCount = 295,
                    CommentsCount = 1,
                },
                new Article()
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "JavaScript ES2021 VE ES2022 Yenilikleri",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the " +
                    "industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled " +
                    "it to make a type specimen book. It has survived not only five centuries, but also the leap into " +
                    "electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release " +
                    "of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus " +
                    "PageMaker including versions of Lorem Ipsum.",
                    Thumbnail = "Default.jpeg",
                    SeoDescription = "JavaScript ES2021 VE ES2022 Yenilikleri",
                    SeoTags = "JS, ES",
                    SeoAuthor = "Yasin Durgun",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "JavaScript Blog Kategorisi",
                    UserId = 1,
                    ViewsCount = 12,
                    CommentsCount = 1,
                }
                );
        }
    }
}
