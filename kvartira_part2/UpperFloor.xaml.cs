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
    /// Логика взаимодействия для UpperFloor.xaml
    /// </summary>
    public partial class UpperFloor : Window
    {
        public UpperFloor()
        {
            InitializeComponent();
        }

        private void FloorPaycheckButton_floor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room upfloor = new Room();
                Room.UpperFloor = upfloor.Rectangle(Room.RoomsLength, Room.RoomsWidth) * Convert.ToDouble(upfloorPayTxb_upfloor.Text);
                upfloorFinaleTxb_upfloor.Text = Room.UpperFloor.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
