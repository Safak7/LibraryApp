using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {

        Task<Author> GetSingleAuthorByIdWithBooksAsync(int authorId);
    }
}
