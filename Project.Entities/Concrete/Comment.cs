using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
   public class Comment:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Comments { get; set; }
        public int BookId { get; set; }

    }
}
