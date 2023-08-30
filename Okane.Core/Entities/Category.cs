namespace Okane.Core.Entities;

public class Category
{
    public int Id { get; set; }
    
    public required string Name { get; set; }
       
    public required int Quantity { get; set; }

    public string? Description { get; set; }

}