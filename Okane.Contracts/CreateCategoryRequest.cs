using System.ComponentModel.DataAnnotations; 

namespace Okane.Contracts
{
    public class CreateCategoryRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        public string? Description { get; set; }
    }
}


