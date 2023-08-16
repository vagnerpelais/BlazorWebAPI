namespace BlazorBackend.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string IconCss { get; set; }
    }
}