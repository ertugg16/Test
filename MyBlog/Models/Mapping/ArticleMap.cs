using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlog.Models.Mapping
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.ArticleID);

            // Properties
            this.Property(t => t.ArticleTitle)
                .IsRequired()
                .HasMaxLength(450);

            this.Property(t => t.ArticleContent)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Article");
            this.Property(t => t.ArticleID).HasColumnName("ArticleID");
            this.Property(t => t.ArticleTitle).HasColumnName("ArticleTitle");
            this.Property(t => t.ArticleContent).HasColumnName("ArticleContent");
            this.Property(t => t.ArticleReleaseDate).HasColumnName("ArticleReleaseDate");
            this.Property(t => t.ArticleCategoryID).HasColumnName("ArticleCategoryID");
            this.Property(t => t.ArticleAuthorID).HasColumnName("ArticleAuthorID");
            this.Property(t => t.ArticleCoverPictureID).HasColumnName("ArticleCoverPictureID");
            this.Property(t => t.ArticleOpening).HasColumnName("ArticleOpening");
            this.Property(t => t.ArticleLike).HasColumnName("ArticleLike");
            this.Property(t => t.ArticleActive).HasColumnName("ArticleActive");

            // Relationships
            this.HasMany(t => t.Tags)
                .WithMany(t => t.Articles)
                .Map(m =>
                    {
                        m.ToTable("ArticleAndTag");
                        m.MapLeftKey("ArticleID");
                        m.MapRightKey("TagID");
                    });

            this.HasMany(t => t.Pictures)
                .WithMany(t => t.Articles1)
                .Map(m =>
                    {
                        m.ToTable("ArticlePicture");
                        m.MapLeftKey("ArticleID");
                        m.MapRightKey("PictureID");
                    });

            this.HasRequired(t => t.Author)
                .WithMany(t => t.Articles)
                .HasForeignKey(d => d.ArticleAuthorID);
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Articles)
                .HasForeignKey(d => d.ArticleCategoryID);
            this.HasRequired(t => t.Picture)
                .WithMany(t => t.Articles)
                .HasForeignKey(d => d.ArticleCoverPictureID);

        }
    }
}
