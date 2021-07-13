using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Publisher:IEntity
    {
        public int? ID { get; set; }
        public string Name { get; set; }

    }
}
