using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWPF
{
    public class TreeViewModel
    {
        public TreeViewModel(BudgetDBContext dbContext)
        {
            RootPeriod = dbContext.Periods.Find(1);
        }

        public Period RootPeriod
        { get; private set; }

        public ICollection<Period> FirstGeneration
        {
            get
            {
                return RootPeriod.Children;
            }
        }
    }
}
