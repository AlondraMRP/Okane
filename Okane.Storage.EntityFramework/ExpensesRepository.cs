using Okane.Core.Entities;
using Okane.Core.Repositories;

namespace Okane.Storage.EntityFramework;

public class ExpensesRepository : IExpensesRepository
{
    private readonly OkaneDbContext _db;

    public ExpensesRepository(OkaneDbContext db) => _db = db;

    public void Add(Expense expense)
    {
        _db.Expenses.Add(expense);
        _db.SaveChanges();
    }

    public IEnumerable<Expense> All() => 
        _db.Expenses;

    public IEnumerable<Expense> ByCategory(string category) => 
        _db.Expenses.Where(expense => expense.Category == category);

    public Expense? ById(int id) => 
        _db.Expenses.FirstOrDefault(expense => expense.Id == id);
    
    public void Delete(int id)
    {
        var expenseToDelete = _db.Expenses.Find(id);

        if (expenseToDelete != null)
        {
            _db.Expenses.Remove(expenseToDelete);
            _db.SaveChanges();
        }
    }
    public void Update(Expense expense)
    {
        _db.Expenses.Update(expense); 
        _db.SaveChanges(); 
    }
}