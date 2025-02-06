using Microsoft.AspNetCore.Mvc;
using SimpleExpenseTracker.Data;
using SimpleExpenseTracker.Models;

namespace SimpleExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly SimpleExpenseTrackerDbContext _context;

        public ExpenseController(SimpleExpenseTrackerDbContext context)
        {
            _context = context;
        }
        public IActionResult IndexExpense() // For the MasterList
        {
            var allExpenses = _context.tblExpense.ToList();

            
            return View(allExpenses);
        }
        
        public IActionResult CreateEditExpense(int? id) // For Creating or Editing Expense Data
        {
            if (id != null)
            {
            var expenseInDb = _context.tblExpense.SingleOrDefault(expense => expense.Id == id);
                return View(expenseInDb);
            }
          
            
            return View();
            
        }
        public IActionResult DeleteExpense(int id) // For Deleting Expense Data
        {
            var expenseInDb = _context.tblExpense.SingleOrDefault(expense => expense.Id == id);
            _context.tblExpense.Remove(expenseInDb);
            _context.SaveChanges();
            return RedirectToAction("IndexExpense");
        }
        
        public IActionResult CreateEditExpenseForm(ExpenseModel model) // For Handling the create edit form
        {
            if (model.Id == 0)
            {
                _context.tblExpense.Add(model);
            }
            else
            {
                _context.tblExpense.Update(model);
            }
                _context.SaveChanges();
            return RedirectToAction("IndexExpense");
        }
    }
}
