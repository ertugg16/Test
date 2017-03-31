using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlog.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.CommentID);

            // Properties
            this.Property(t => t.CommentTitle)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.CommentContent)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Comment");
            this.Property(t => t.CommentID).HasColumnName("CommentID");
            this.Property(t => t.CommentTitle).HasColumnName("CommentTitle");
            this.Property(t => t.CommentContent).HasColumnName("CommentContent");
            this.Property(t => t.CommentArticleID).HasColumnName("CommentArticleID");
            this.Property(t => t.CommentDate).HasColumnName("CommentDate");

            // Relationships
            this.HasRequired(t => t.Article)
                .WithMany(t => t.Comments)
                .HasForeignKey(d => d.CommentArticleID);

        }
    }
}
