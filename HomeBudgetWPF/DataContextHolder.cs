using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWPF
{
    public class DataContextHolder
    {
        public BudgetDBContext BugdetBD { get; private set; }
        public static DataContextHolder Instance { get; private set;}

        private DataContextHolder()
        {
            BugdetBD = new BudgetDBContext();           
        }

        static DataContextHolder()
        {
            Instance = new DataContextHolder();
        }

        public void Save()
        {
            BugdetBD.Commit();
        }
    }
}
