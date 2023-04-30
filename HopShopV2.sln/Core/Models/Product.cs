namespace Core.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ABV { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Country { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
