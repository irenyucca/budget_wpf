using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeBudgetWPF
{
    /// <summary>
    /// Interaction logic for ExpenseCtrl.xaml
    /// </summary>
    public partial class ExpenseCtrl : UserControl
    {
        public ExpenseCtrl()
        {
            InitializeComponent();
        }
        public DataGrid ExpDataGrid
        {
            get { return this.expGrid; }
        }
    }
}
