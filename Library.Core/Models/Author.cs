using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public class Author:BaseEntity
    {
        public ICollection<Book> Books { get; set; }
    }
}
