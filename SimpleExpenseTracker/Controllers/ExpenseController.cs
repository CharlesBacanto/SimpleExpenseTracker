using Microsoft.AspNetCore.Mvc;

namespace SimpleExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult IndexExpense()
        {
            return View();
        }
        
        public IActionResult CreateEditExpense()
        {
            return View();
        }
    }
}
