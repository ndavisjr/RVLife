using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RVLife.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense")]
        [Required]
        public string ExpsenseName { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage ="Amount must be greater than 0")]
        public double Amount { get; set; }
    }
}
