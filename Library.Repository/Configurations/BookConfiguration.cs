using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(8,2)");
   

            builder.HasOne(x=>x.Publisher).WithMany(x=>x.Books).HasForeignKey(x=>x.PublisherId);
            builder.HasOne(x=>x.Author).WithMany(x=>x.Books).HasForeignKey(x=>x.AuthorId);
        }
    }
}
