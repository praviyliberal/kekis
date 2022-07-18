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

namespace kvartira_part2
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

        private void doorPaycheckButton_start_Click(object sender, RoutedEventArgs e)
        {
            Door door = new Door();
            door.ShowDialog();
            labelFinale1_start.Content = Room.Door.ToString();
        }

        private void bathPaycheckButton_start_Click(object sender, RoutedEventArgs e)
        {
            Bath bath = new Bath();
            bath.ShowDialog();
            labelFinale2_start.Content = Room.Bath.ToString();
        }

        private void FloorPaycheckButton_start_Click(object sender, RoutedEventArgs e)
        {
            Floor floor = new Floor();
            floor.ShowDialog();
            labelFinale3_start.Content = Room.Floor.ToString();
        }

        private void roomLengthTxb_start_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Room.RoomsLength = Convert.ToDouble(roomLengthTxb_start.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка.");
            }
        }

        private void roomWidthTxb_start_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Room.RoomsWidth = Convert.ToDouble(roomWidthTxb_start.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка.");
            }
        }

        private void roomHeightTxb_start_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Room.RoomsHeight = Convert.ToDouble(roomHeightTxb_start.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка.");
            }
        }

        private void UpperFloorPaycheckButton_start_Click(object sender, RoutedEventArgs e)
        {
            UpperFloor upfloor = new UpperFloor();
            upfloor.ShowDialog();
            labelFinale4_start.Content = Room.UpperFloor.ToString();
        }

        private void WallsPaycheckButton_start_Click(object sender, RoutedEventArgs e)
        {
            Walls walls = new Walls();
            walls.ShowDialog();
            labelFinale5_start.Content = Room.Walls.ToString();
        }
    }
}
