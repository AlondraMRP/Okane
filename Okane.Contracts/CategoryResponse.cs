
namespace Okane.Contracts
{
    public class CategoryResponse
    {
        public int Id { get; set; }

        
        public required string Name { get; set; }

       
        public required int Quantity { get; set; }

        public string? Description { get; set; }
    }
}