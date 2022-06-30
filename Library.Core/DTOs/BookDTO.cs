using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs
{
    public class BookDTO:BaseDTO
    {
        public int NumberOfPages { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
    }
}
