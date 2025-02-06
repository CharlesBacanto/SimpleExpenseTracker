using Microsoft.EntityFrameworkCore;
using SimpleExpenseTracker.Models;

namespace SimpleExpenseTracker.Data
{
    public class SimpleExpenseTrackerDbContext :DbContext
    {
        public DbSet<ExpenseModel> tblExpense { get; set; }

        public SimpleExpenseTrackerDbContext(DbContextOptions<SimpleExpenseTrackerDbContext> options) : base(options)
        {
                
        }
    }
}
