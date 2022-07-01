using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
 
    public class BooksController : CustomBaseContolller
    {
        private readonly IMapper _mapper;
        private readonly IService<Book> _service;
        public BooksController(IMapper mapper, IService<Book> service)
        {
            _mapper = mapper;
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var books = await _service.GetAllAsync();
          
            var booksDtos = _mapper.Map<List<BookDTO>>(books.ToList());

            return CreateActionResult(CustomResponseDTO<List<BookDTO>>.Success(200, booksDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _service.GetByIdAsync(id);
            var booksDto = _mapper.Map<BookDTO>(book);
            return CreateActionResult(CustomResponseDTO<BookDTO>.Success(200, booksDto));
        }
        [HttpPost()]
        public async Task<IActionResult> Save(BookDTO bookDto)
        {
            var book = await _service.AddAsync(_mapper.Map<Book>(bookDto));
            var booksDto = _mapper.Map<BookDTO>(book);
            return CreateActionResult(CustomResponseDTO<BookDTO>.Success(201, booksDto));
        }
        [HttpPut()]
        public async Task<IActionResult> Update(BookDTO bookDto)
        {
            await _service.UpdateAsync(_mapper.Map<Book>(bookDto));
            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        { 
            var book = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(book);
            return CreateActionResult(CustomResponseDTO<NoContentDTO>.Success(204));
        }

    }
}
