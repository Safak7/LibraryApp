using Library.Core.Models;
using Library.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Repositories
{
    public class AuthorRepository:GenericRepository<Author>, IAuthorRepository

    {
        public AuthorRepository(AppDbContext context):base(context)
        {

        }
        public async Task<Author> GetSingleAuthorByIdWithBooksAsync(int authorId)
        {
            return await _context.Authors.Include(x => x.Books).Where(x => x.Id == authorId).SingleOrDefaultAsync();
        }
    }
}
