using Library.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    
    public class AuthorController : CustomBaseContolller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

       
        [HttpGet("[action]/{authorId}")]
        public async Task<IActionResult> GetSingleAuthorByIdWithBooks(int authorId)
        {

            return CreateActionResult(await _authorService.GetSingleAuthorByIdWithBooksAsync(authorId));

        }

    }
}
