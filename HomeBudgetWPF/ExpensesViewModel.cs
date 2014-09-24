using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWPF
{
    public class ExpensesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Expense> expenses = new ObservableCollection<Expense>();
        private double totalExpense;
        BudgetDBContext dbContext;
        public ExpensesViewModel(BudgetDBContext dbContext, int recid)
        {
            foreach (Expense exp in dbContext.Periods.Find(recid).Expenses)
            {
                this.expenses.Add(exp);
                totalExpense += exp.Amount;
            }
            this.dbContext = dbContext;
            expenses.CollectionChanged += expenses_CollectionChanged;
        }

        void expenses_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action.Equals(NotifyCollectionChangedAction.Add))
            {
                foreach (Expense exp in e.NewItems)
                {
                    dbContext.Expenses.Add(exp);
                    dbContext.Periods.First().Expenses.Add(exp);
                }                
            }
            if (e.Action.Equals(NotifyCollectionChangedAction.Remove))
            {
                foreach (Expense exp in e.OldItems)
                {
                    dbContext.Expenses.Remove(exp);
                }  
            }
        }

        public double TotalExpense
        {   get { return this.totalExpense; }
            set { 
                totalExpense = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("TotalExpense"));
                }
            }

        }
        public ObservableCollection<Expense> Expenses
        {
            get { return expenses; }
        }
    }
}
