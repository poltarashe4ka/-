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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
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

        /// <summary>
        /// Метод по нажатию кнопки выполняет подсчёт максимального числа и выводит его в текстбокс res
        /// </summary>

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(_1st.Text);
            int b = Convert.ToInt32(_2nd.Text);
            int c = Convert.ToInt32(_3rd.Text);
            int d = Convert.ToInt32(_4th.Text);
            int max = Math.Max(Math.Max(a, b), Math.Max(c,d));
            res.Text = Convert.ToString(max);


        }
    }
}
