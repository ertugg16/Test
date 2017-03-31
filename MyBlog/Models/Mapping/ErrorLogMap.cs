using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlog.Models.Mapping
{
    public class ErrorLogMap : EntityTypeConfiguration<ErrorLog>
    {
        public ErrorLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ErrorLogID);

            // Properties
            this.Property(t => t.ErrorLogDescription)
                .HasMaxLength(2250);

            // Table & Column Mappings
            this.ToTable("ErrorLog");
            this.Property(t => t.ErrorLogID).HasColumnName("ErrorLogID");
            this.Property(t => t.ErrorLogDescription).HasColumnName("ErrorLogDescription");
        }
    }
}
