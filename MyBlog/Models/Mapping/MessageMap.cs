using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlog.Models.Mapping
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageID);

            // Properties
            this.Property(t => t.MesageDescription)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.MessageEmail)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Message");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.MessageSendDate).HasColumnName("MessageSendDate");
            this.Property(t => t.MesageDescription).HasColumnName("MesageDescription");
            this.Property(t => t.MessageEmail).HasColumnName("MessageEmail");
        }
    }
}
