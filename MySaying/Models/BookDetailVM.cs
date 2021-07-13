using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySaying.Models
{
    public class BookDetailVM
    {
        public Book Book { get; set; } = new Book();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
