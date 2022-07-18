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
    /// Логика взаимодействия для Door.xaml
    /// </summary>
    public partial class Door : Window
    {
        public Door()
        {
            InitializeComponent();
        }
        private void DoorPaycheck_door_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room room = new Room();
                Room.DoorsLength = Convert.ToDouble(doorsLengthTxb_door.Text);
                Room.DoorsHeight = Convert.ToDouble(doorsHeightTxb_door.Text);
                Room.Door = room.Rectangle(Room.DoorsLength, Room.DoorsHeight);
                doorsFinaleTxb_door.Text = (Room.Door * Convert.ToDouble(doorsPayTxb_door.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
