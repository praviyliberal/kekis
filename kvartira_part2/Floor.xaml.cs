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
    /// Логика взаимодействия для Floor.xaml
    /// </summary>
    public partial class Floor : Window
    {
        public Floor()
        {
            InitializeComponent();
        }

        private void FloorPaycheckButton_floor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room floor = new Room();
                Room.Floor = (floor.Rectangle(Room.RoomsLength, Room.RoomsWidth) - (floor.Circle(Room.BathsRange) / 4)) * Convert.ToDouble(floorPayTxb_floor.Text);
                floorFinaleTxb_floor.Text = Room.Floor.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
