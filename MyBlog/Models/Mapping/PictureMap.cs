using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlog.Models.Mapping
{
    public class PictureMap : EntityTypeConfiguration<Picture>
    {
        public PictureMap()
        {
            // Primary Key
            this.HasKey(t => t.PictureID);

            // Properties
            this.Property(t => t.PictureName)
                .IsRequired()
                .HasMaxLength(350);

            // Table & Column Mappings
            this.ToTable("Picture");
            this.Property(t => t.PictureID).HasColumnName("PictureID");
            this.Property(t => t.PictureName).HasColumnName("PictureName");
            this.Property(t => t.PictureAddingAuthor).HasColumnName("PictureAddingAuthor");
            this.Property(t => t.PictureAddDate).HasColumnName("PictureAddDate");
            this.Property(t => t.PictureOpening).HasColumnName("PictureOpening");

            // Relationships
            this.HasRequired(t => t.Author)
                .WithMany(t => t.Pictures)
                .HasForeignKey(d => d.PictureAddingAuthor);

        }
    }
}
