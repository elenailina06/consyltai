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
using Microsoft.Win32;

namespace WpfApp7
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a=Convert.ToInt32(кг.Text);
            int b = Convert.ToInt32(цена.Text);
            int c = Convert.ToInt32(ккг.Text);



            int d = b*c/a;
            итог.Text = "результат " + d;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog txt = new OpenFileDialog();
            if (txt.ShowDialog() == true) {
                string fileName = txt.FileName;
                img1.Source = new BitmapImage(new Uri(fileName));
            }
        }


    }
}
