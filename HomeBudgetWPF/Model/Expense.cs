using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWPF
{
    public class Expense : ICloneable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ModDate { get; set; }

        public virtual Category ExpCategory { get; set; }


        public object Clone()
        {
            Expense copy = new Expense();
            copy.Id = this.Id;
            copy.Description = this.Description;
            copy.Amount = this.Amount;
            copy.AddDate = this.AddDate;
            copy.ModDate = this.ModDate;
            return copy;
        }
    }
}
