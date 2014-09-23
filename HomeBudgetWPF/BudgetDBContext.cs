using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWPF
{
    public class BudgetDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

    }
}
