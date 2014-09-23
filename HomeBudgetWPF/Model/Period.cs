using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWPF
{
    public class Period
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Income { get; set; }
        public double? ExtIncome { get; set; }
        
        public virtual ICollection<Period> Children { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        
    }
}
