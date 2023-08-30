using Okane.Contracts;
using Okane.Core.Entities;

namespace Okane.Core.Repositories
{
    public interface ICategoryRepository
    {
        void Add(Category? category);
        IEnumerable<Category> All();
        Category? ById(int id);
        void Delete(int id);
    }
}