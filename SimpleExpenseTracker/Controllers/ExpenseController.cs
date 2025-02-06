using Microsoft.AspNetCore.Mvc;
using SimpleExpenseTracker.Models;

namespace SimpleExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult IndexExpense() // For the MasterList
        {
            return View();
        }
        
        public IActionResult CreateEditExpense() // For Creating or Editing Expense Data
        {
            return View();
        }
        
        public IActionResult CreateEditExpenseForm(ExpenseModel model) // For Handling the create edit form
        {
            return RedirectToAction("IndexExpense");
        }
    }
}
