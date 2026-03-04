using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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
			DeleteAllCells();
			CreateCells();
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			SaveFile();
		}
		
		private void DeleteAllCells()
		{
			for (int i = 0; i < grid_bingo.Children.Count; i++)
			{
				if (grid_bingo.Children[i] is TextBox)
				{
					grid_bingo.Children.Remove(grid_bingo.Children[i] as TextBox);
				}
			}
		}

		private void CreateCells()
		{
			Random random = new Random();
			List<int> szam_1_15 = Enumerable.Range(1, 15).ToList();
			List<int> szam_16_30 = Enumerable.Range(16, 15).ToList();
			List<int> szam_31_45 = Enumerable.Range(31, 15).ToList();
			List<int> szam_46_60 = Enumerable.Range(46, 15).ToList();
			List<int> szam_61_75 = Enumerable.Range(61, 15).ToList();

			for (int r = 0; r < 5; r++)
			{
				for (int c = 0; c < 5; c++)
				{
					TextBox textbox = new TextBox();
					Grid.SetRow(textbox, r);
					Grid.SetColumn(textbox, c);
					textbox.FontSize = 20;
					textbox.FontFamily = new FontFamily("Broadway");
					textbox.VerticalAlignment = VerticalAlignment.Stretch;
					textbox.HorizontalAlignment = HorizontalAlignment.Stretch;
					textbox.VerticalContentAlignment = VerticalAlignment.Center;
					textbox.HorizontalContentAlignment = HorizontalAlignment.Center;
					grid_bingo.Children.Add(textbox);


					if (c == 0)
					{
						int index = random.Next(szam_1_15.Count);				
						textbox.Text = $"{szam_1_15[index]}";
						szam_1_15.RemoveAt(index);
					}
					if (c == 1)
					{
						int index = random.Next(szam_16_30.Count);
						textbox.Text = $"{szam_16_30[index]}";
						szam_16_30.RemoveAt(index);
					}
					if (c == 2)
					{
						int index = random.Next(szam_31_45.Count);
						textbox.Text = $"{szam_31_45[index]}";
						szam_31_45.RemoveAt(index);
					}
					if (c == 3)
					{
						int index = random.Next(szam_46_60.Count);
						textbox.Text = $"{szam_46_60[index]}";
						szam_46_60.RemoveAt(index);
					}
					if (c == 4)
					{
						int index = random.Next(szam_61_75.Count);
						textbox.Text = $"{szam_61_75[index]}";
						szam_61_75.RemoveAt(index);
					}
					if (r == 2 && c == 2)
					{
						textbox.Text = "X";
						textbox.IsEnabled = false;
					}
				}
			}
		}

		private void SaveFile()
		{
			List<string> list = new List<string>();
			string line = "";
			int i = 0;

			foreach (var item in grid_bingo.Children)
			{
				if (item is TextBox)
				{
					TextBox textboxChildren = (TextBox)item;
					line += $"{textboxChildren.Text};";
					i++;
				}
				if (i == 5)
				{
					line = line.Remove(line.Length - 1);
					list.Add(line);
					line = "";
					i = 0;
				}
			}
			try
			{
				File.WriteAllLines($"{txtbox_input.Text}", list);
				MessageBox.Show("Az állomány mentése sikeres");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public MainWindow()
        {
            InitializeComponent();
        }
    }
}