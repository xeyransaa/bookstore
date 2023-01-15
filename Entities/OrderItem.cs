using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderItem : IEntity
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int BookId { get; set; }
        public int Count { get; set; }
    }
}
