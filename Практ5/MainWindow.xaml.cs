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

namespace Практ5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] array1; char[] array2; char[] array3; char[] array4; char[] array5;
        public MainWindow()
        {
            InitializeComponent();
          
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int.TryParse(ArrayLongTB.Text, out int M);
            if (M < 101 && M > 0)
            {
                Random rnd = new Random();

                array1 = new char[M]; array2 = new char[M]; array3 = new char[M]; array4 = new char[M]; array5 = new char[M];
                FillArray.FillArray1(array1, rnd); FillArray.FillArray1(array2, rnd); FillArray.FillArray1(array3, rnd); FillArray.FillArray1(array4, rnd); FillArray.FillArray1(array5, rnd);
                Array1DG.ItemsSource = VisualArray.ToDataTable(array1).DefaultView; Array2DG.ItemsSource = VisualArray.ToDataTable(array2).DefaultView; Array3DG.ItemsSource = VisualArray.ToDataTable(array3).DefaultView; Array4DG.ItemsSource = VisualArray.ToDataTable(array4).DefaultView; Array5DG.ItemsSource = VisualArray.ToDataTable(array5).DefaultView;
            }
            else { MessageBox.Show("Задайте корректный размер массива"); }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Массив 1 буквы чередуются = {CheckArray.CheckAlternatingCase(array1)}\nМассив 2 буквы чередуются = {CheckArray.CheckAlternatingCase(array2)}\nМассив 3 буквы чередуются = {CheckArray.CheckAlternatingCase(array3)}\nМассив 4 буквы чередуются = {CheckArray.CheckAlternatingCase(array4)}\nМассив 5 буквы чередуются = {CheckArray.CheckAlternatingCase(array5)}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Даны пять массивов содержащие только латинкские буквы(строчные и заглавные)\nОпределить чередуются ли строчные и прописные буквы");
        }
    }
}
