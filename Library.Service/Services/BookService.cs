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
    public class BookService : Service<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IGenericRepository<Book> repository, IUnitOfWork unitOfWork, IMapper mapper, IBookRepository productRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _bookRepository = productRepository;
        }
        public async Task<CustomResponseDTO<List<BooksWithAuthorDTO>>> GetBooksWithAuthor()
        {
            var products = await _bookRepository.GetBooksWithAuthor();

            var productsDto = _mapper.Map<List<BooksWithAuthorDTO>>(products);
            return CustomResponseDTO<List<BooksWithAuthorDTO>>.Success(200, productsDto);

        }
    }
}
