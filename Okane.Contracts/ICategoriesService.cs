
namespace Okane.Contracts;

public interface ICategoryService
{
    CategoryResponse Register(CreateCategoryRequest request);
    IEnumerable<CategoryResponse> Retrieve(string? expense);
    CategoryResponse? ByName(string name);
    void Delete (string name);

    void Update (CategoryResponse name);
}

