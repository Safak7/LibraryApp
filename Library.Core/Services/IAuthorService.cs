using Library.Core.DTOs;
using Library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public interface IAuthorService : IService<Author>
    {
        public Task<CustomResponseDTO<AuthorWithBooksDto>> GetSingleAuthorByIdWithBooksAsync(int authorId);

    }
}
