using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
   public class Saying:IEntity
    {
        public int? ID { get; set; }
        public int BookId { get; set; }
        public string Say { get; set; }
    }
}
