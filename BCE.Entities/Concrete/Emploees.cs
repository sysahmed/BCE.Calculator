using BCE.Core.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace BCE.Entities.Concrete
{
    public class Employees :Salary, IEntities
    {
        public int EmloeeId { get; set; }

        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Invalid Name ")]
        public string FullName { get; set; } 
        
        [Range(10000, 9999999999, ErrorMessage = "You can enter numbers from 10000 то 9999999999")]
        [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a Number.")]
        public decimal SSN { get; set; }
        //public decimal GrossIncome {private get; set; }
        private decimal grossIncome;
        [Required]
        public decimal GrossIncome { get { return grossIncome; } set { grossIncome = value; } }
        [Required]
        public DateTime DateOfBirth { get; set; }

    }
}
