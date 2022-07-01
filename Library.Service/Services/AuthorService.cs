using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Services
{
    public class AuthorService : Service<Author>, IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IGenericRepository<Author> repository, IUnitOfWork unitOfWork, IMapper mapper, IAuthorRepository authorRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
        }
        public async Task<CustomResponseDTO<AuthorWithBooksDto>> GetSingleAuthorByIdWithBooksAsync(int authorId)
        {
            var author = await _authorRepository.GetSingleAuthorByIdWithBooksAsync(authorId);

            var authorDto = _mapper.Map<AuthorWithBooksDto>(author);

            return CustomResponseDTO<AuthorWithBooksDto>.Success(200, authorDto);

        }

      
    }
}
