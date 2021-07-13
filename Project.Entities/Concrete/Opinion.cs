using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Opinion:IEntity
    {

        public int Id { get; set; }
        public string WriterName { get; set; }
        public string Say { get; set; }
        public string BookName { get; set; }



    }
}
