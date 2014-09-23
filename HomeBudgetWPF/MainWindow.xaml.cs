using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.SqlServerCe;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        PeriodViewModel periodView;
        public MainWindow()
        {
            InitializeComponent();
            
            periodView = new PeriodViewModel(DataContextHolder.Instance.BugdetBD);
            ctrl.DataContext = periodView;
            ctrl.ExpDataGrid.DataContext = periodView.Expenses;
            
            List<Category> categories = new List<Category>();
            foreach (Category cat in DataContextHolder.Instance.BugdetBD.Categories)
            {
                categories.Add(cat);
            }
            Resources["Categories"] = categories;

            tree.DataContext = new TreeViewModel(DataContextHolder.Instance.BugdetBD);
            
 
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            DataContextHolder.Instance.BugdetBD.SaveChanges();            
        }
        
    }
}
