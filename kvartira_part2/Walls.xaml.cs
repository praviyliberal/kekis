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
using System.Windows.Shapes;

namespace kvartira_part2
{
    /// <summary>
    /// Логика взаимодействия для Walls.xaml
    /// </summary>
    public partial class Walls : Window
    {
        public Walls()
        {
            InitializeComponent();
        }

        private void FloorPaycheckButton_floor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room wall = new Room();

                //Первая стена с дверью
                double wall1 = (wall.Rectangle(Room.RoomsLength, Room.RoomsHeight) - Room.Door) * Convert.ToDouble(wallsPayTxb_walls.Text);
                //Вторая стена справа
                double wall2 = wall.Rectangle(Room.RoomsWidth, Room.RoomsHeight) * Convert.ToDouble(wallsPayTxb_walls.Text);
                //Стены с ванной
                double wall3 = (wall.Rectangle(Room.RoomsLength, Room.RoomsHeight) - wall.Rectangle(Room.BathsRange, Room.BathsHeight)) * Convert.ToDouble(wallsPayTxb_walls.Text);
                double wall4 = (wall.Rectangle(Room.RoomsWidth, Room.RoomsHeight) - wall.Rectangle(Room.BathsRange, Room.BathsHeight)) * Convert.ToDouble(wallsPayTxb_walls.Text);

                Room.Walls = wall1 + wall2 + wall3 + wall4;
                wallsFinaleTxb_walls.Text = Room.Walls.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
