using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlog.Models.Mapping
{
    public class VisitorLogMap : EntityTypeConfiguration<VisitorLog>
    {
        public VisitorLogMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitorLogID);

            // Properties
            this.Property(t => t.VisitorIP)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("VisitorLogs");
            this.Property(t => t.VisitorLogID).HasColumnName("VisitorLogID");
            this.Property(t => t.VisitorLogDate).HasColumnName("VisitorLogDate");
            this.Property(t => t.VisitorIP).HasColumnName("VisitorIP");
            this.Property(t => t.VisitorCount).HasColumnName("VisitorCount");
        }
    }
}
