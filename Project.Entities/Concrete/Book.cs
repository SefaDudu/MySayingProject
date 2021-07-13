using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Entities.Concrete
{
   public class Book:IEntity
    {  //null mu 
        public int? ID { get; set; }
        public string Name { get; set; }
        public string PDF { get; set; }
        public int PublisherId { get; set; }
        public int WriterId { get; set; }
    }
}
