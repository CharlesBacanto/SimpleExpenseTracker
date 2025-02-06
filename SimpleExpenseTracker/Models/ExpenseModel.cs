using System.ComponentModel.DataAnnotations;

namespace SimpleExpenseTracker.Models
{
    public class ExpenseModel
    {
        public int Id { get; set; }

        public int Value { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
