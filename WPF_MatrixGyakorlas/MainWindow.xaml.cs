using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_MatrixGyakorlas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
		private void console_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void btnSize_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void btnSleep_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void btnCreate_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{

		}
		
		public MainWindow()
        {
            InitializeComponent();
        }
    }
}