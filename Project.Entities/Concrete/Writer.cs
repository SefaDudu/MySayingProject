using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Writer:IEntity
    {
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
