using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWPF
{
    public class PeriodViewModel
    {
        public Period period;
        private double expended;
        public ExpensesViewModel expensesViewModel;
        public PeriodViewModel(BudgetDBContext dbContext, int recid)
        {
            this.period = dbContext.Periods.Find(recid);
            this.expensesViewModel = new ExpensesViewModel(dbContext, recid);
        }
        public string Name
        {
            get { return this.period.Name; }
        }
        public double Income
        {
            get { return this.period.Income.HasValue?Double.Parse(this.period.Income.Value.ToString()):0; }
            set { this.period.Income = value; }
        }
        public double ExtraIncome
        {
            get { return this.period.ExtIncome.HasValue ? Double.Parse(this.period.ExtIncome.Value.ToString()) : 0; }
            set { this.period.ExtIncome = value; }
        }
        public double Residual
        {
            get { return this.period.Income.HasValue?this.period.Income.Value - expensesViewModel.TotalExpense : 0; }
        }
        public double Expended
        {
            get { return this.expensesViewModel.TotalExpense; }
        }
        public ObservableCollection<Expense> Expenses
        {
            get { return this.expensesViewModel.Expenses; }
        }
    }
}
