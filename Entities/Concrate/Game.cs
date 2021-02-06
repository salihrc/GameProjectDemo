using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public decimal UnitPrice { get; set; }

      
    }
}
