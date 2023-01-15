using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public virtual Author? Author { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public decimal Rating { get; set; }
        public decimal GoodreadsRating { get; set; }
        public string Description { get; set; }
        public int PagesNumber { get; set; }
        public string Format { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime Modified { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsDeleted { get; set; }
        public int ISBN { get; set; }
        public List<Review> Reviews { get; set; }
        public int BookLanguageId { get; set; }
        public virtual BookLanguage? BookLanguage { get; set; }
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        public string Dimensions { get; set; }
        public int CountInStock { get; set; }


    }
}
