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

namespace кости
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random ran = new Random();
        int a, b, c;
        int lives = 10;
        double d = 1000;
        private MediaPlayer ding;
        public MainWindow()
        {
            InitializeComponent();
            ding = new MediaPlayer();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double CASH = Convert.ToDouble(inputcash.Text);
                ding.Open(new Uri(@"C:\Users\matve\source\repos\кости\Project\ding.mp3", UriKind.Absolute));
                ding.Play();
                //Проверка на ставку 
                if (CASH > d)
                {
                    MessageBox.Show("Недостаточно баланса!!! Вы проиграли...");
                    Close();
                }
                //Выйгрыш
                if (d >= 10000 && lives >0)
                {
                    MessageBox.Show("Поздравляю! Вы...прошли...игру!");
                    Close();
                }
                //Пройгрыш
                if (lives == 0)
                {
                    MessageBox.Show("Вы проиграли :С");
                    Close();
                }
                //Генерация кубиков и подсчет их суммы
                a = ran.Next(1, 6);
                b = ran.Next(1, 6);
                c = a + b;
                sum.Content = c.ToString();

                //1.1х
                if (one.IsChecked == true)
                {
                    if (c >= 4)
                    {
                        d = d + CASH * 1.1;
                        Cash.Content = d.ToString();
                    }
                    else
                    {
                        d = d - CASH;
                        Cash.Content = d.ToString();
                        lives--;
                        Lives.Content = lives.ToString();
                    }
                }
                //1.3х
                if (two.IsChecked == true)
                {
                    if (c >= 6)
                    {
                        d = d + CASH * 1.3;
                        Cash.Content = d.ToString();
                    }
                    else
                    {
                        d = d - CASH;
                        Cash.Content = d.ToString();
                        lives--;
                        Lives.Content = lives.ToString();
                    }
                }
                //1.5х
                if (three.IsChecked == true)
                {
                    if (c >= 8)
                    {
                        d = d + CASH * 1.5;
                        Cash.Content = d.ToString();
                    }
                    else
                    {
                        d = d - CASH;
                        Cash.Content = d.ToString();
                        lives--;
                        Lives.Content = lives.ToString();
                    }
                }
                // 2х
                if (four1.IsChecked == true)
                {
                    if (c >= 10)
                    {
                        d = d + CASH * 2;
                        Cash.Content = d.ToString();
                    }
                    else
                    {
                        d = d - CASH;
                        Cash.Content = d.ToString();
                        lives--;
                        Lives.Content = lives.ToString();
                    }

                    //Первый кубик
                }
                if (a == 1)
                {
                    first.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\1.png"));
                }
                else if (a == 2)
                {
                    first.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\2.png"));
                }
                else if(a == 3)
                {
                    first.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\3.png"));
                }
                else if(a == 4)
                {
                    first.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\4.png"));
                }
                else if(a == 5)
                {
                    first.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\5.png"));
                }
                else if(a == 6)
                {
                    first.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\6.png"));
                }

                //Второй кубик
                if (b == 1)
                {
                    second.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\1.png"));
                }
                else if(b == 2)
                {
                    second.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\2.png"));
                }
                else if(b == 3)
                {
                    second.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\3.png"));
                }
                else if(b == 4)
                {
                    second.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\4.png"));
                }
                else if(b == 5)
                {
                    second.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\5.png"));
                }
                else if(b == 6)
                {
                    second.Source = new BitmapImage(new Uri("C:\\Users\\matve\\source\\repos\\кости\\Project\\6.png"));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("А ну давай играй по правилам!!!");
            }
        }
    }
}
