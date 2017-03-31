using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlog.Models.Mapping
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            // Primary Key
            this.HasKey(t => t.AuthorID);

            // Properties
            this.Property(t => t.AuthorName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuthorSurname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuthorMail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuthorNickname)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Author");
            this.Property(t => t.AuthorID).HasColumnName("AuthorID");
            this.Property(t => t.AuthorName).HasColumnName("AuthorName");
            this.Property(t => t.AuthorSurname).HasColumnName("AuthorSurname");
            this.Property(t => t.AuthorMail).HasColumnName("AuthorMail");
            this.Property(t => t.AuthorCreateDate).HasColumnName("AuthorCreateDate");
            this.Property(t => t.AuthorNickname).HasColumnName("AuthorNickname");
            this.Property(t => t.AuthorPictureID).HasColumnName("AuthorPictureID");
            this.Property(t => t.AuthorActive).HasColumnName("AuthorActive");

            // Relationships
            this.HasRequired(t => t.Picture)
                .WithMany(t => t.Authors)
                .HasForeignKey(d => d.AuthorPictureID);

        }
    }
}
