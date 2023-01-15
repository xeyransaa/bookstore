using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BookLanguage:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
 