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
        
        public IActionResult CreateEditExpense() // For Creating or Editing Expense Data
        {
            return View();
        }
        
        public IActionResult CreateEditExpenseForm(ExpenseModel model) // For Handling the create edit form
        {
            _context.tblExpense.Add(model);
            _context.SaveChanges();
            return RedirectToAction("IndexExpense");
        }
    }
}
