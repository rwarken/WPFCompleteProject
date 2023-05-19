using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WPF_CompleteProject.Data;
using WPF_CompleteProject.Data.DataModel;

namespace WPFCompleteProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
	{
		List<Employee> employees = new List<Employee>();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void ButtonExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void ButtonGetEmployees_Click(object sender, RoutedEventArgs e)
		{
			GetEmployees();
		}

		void GetEmployees()
		{
			var db = new WPFCompleteProjectDb().Employees;
			employees = db.ToList();
			DataGridEmployees.ItemsSource = employees;
		}

		private List<Employee> GetInt32(List<Employee> employees)
		{
			throw new NotImplementedException();
		}
	}
}
