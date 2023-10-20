using System;
using lib3;
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
using пр2_головиной;

namespace пр3_Головина
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        int[,] matr;

        private void mas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void matr1_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //номер столбца и строки
            int indexColumn = e.Column.DisplayIndex;
            int indexRow = e.Row.GetIndex();
            matr[indexRow, indexColumn] = Convert.ToInt32(((TextBox)e.EditingElement).Text);
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            //строка к
            int K = Convert.ToInt32(kolK1.Text);
            string sumpr;
            //рассчитать сумму и произведение
            Pr3.Func(out sumpr, matr, K);
            //вывод суммы и произведения
            sumpr1.Text = sumpr;
        }

        // отдельно настроить чтобы можно было изменить в массиве
        private void Fill_Click(object sender, RoutedEventArgs e)
        {
            //кол-во колонок и строк
            int kol = Convert.ToInt32(kol1.Text);
            int str = Convert.ToInt32(str1.Text);
            //диапазон
            int dip = Convert.ToInt32(dip1.Text);
            //заполн табл рандомом
            Pr3.Massiv(out matr, kol, str, dip);
            //вывод массива
            matr1.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
