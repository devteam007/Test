using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entities
{
    public class Product
    {
        [Key]
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }
}