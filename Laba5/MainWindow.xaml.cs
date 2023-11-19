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

namespace Laba5
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
            var tabul = new Tabul();
            tabul.GetList(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text),
                Convert.ToDouble(textBox3.Text));
            listBox1.Items.Clear();
            for(int i = 0; i < tabul.points.Count; i++)
            {
                listBox1.Items.Add("x=" + Math.Round(tabul.points[i].X, 2).ToString()
                    + " y=" + Math.Round(tabul.points[i].Y, 3).ToString()
                    + " Цикл=" + Math.Round(tabul.points[i].Y_cikl, 3).ToString()
                    + " Рекурсія= " + Math.Round(tabul.points[i].Y_rek, 3).ToString()
                    );
            }
        }
    }
}
