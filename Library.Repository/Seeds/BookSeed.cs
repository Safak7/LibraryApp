using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Seeds
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
                (
                    new Book { Id = 1, AuthorId = 1, PublisherId = 1, Name = "Book One", ISBN = "11111", Price = 35.25, NumberOfPages = 325 },
                    new Book { Id = 2, AuthorId = 1, PublisherId = 1, Name = "Book Two", ISBN = "22222", Price = 22.75, NumberOfPages = 625 },
                    new Book { Id = 3, AuthorId = 2, PublisherId = 1, Name = "Book Three", ISBN = "33333", Price = 15.65, NumberOfPages = 550 },
                    new Book { Id = 4, AuthorId = 2, PublisherId = 2, Name = "Book Four", ISBN = "44444", Price = 155.40, NumberOfPages = 438 },
                    new Book { Id = 5, AuthorId = 3, PublisherId = 2, Name = "Book Five", ISBN = "55555", Price = 125.25, NumberOfPages = 1275 },
                    new Book { Id = 6, AuthorId = 3, PublisherId = 2, Name = "Book Six", ISBN = "66666", Price = 45.15, NumberOfPages = 128 }
                );
        }
    }
}
