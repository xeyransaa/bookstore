using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Review:IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public decimal? Rating { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
