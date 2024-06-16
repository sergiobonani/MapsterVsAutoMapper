namespace MapsterVsAutoMapper.Model
{
    public class Product
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public List<string> Tags { get; set; } = default!;
    }
}
