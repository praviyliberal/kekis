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
    /// Логика взаимодействия для Bath.xaml
    /// </summary>
    public partial class Bath : Window
    {
        public Bath()
        {
            InitializeComponent();
        }

        private void DoorPaycheck_door_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room bath = new Room();
                Room.BathsRange = Convert.ToDouble(bathRangeTxb_bath.Text);
                Room.BathsHeight = Convert.ToDouble(bathHeightTxb_bath.Text);
                Room.Bath = (bath.Circle(Room.BathsRange) / 4) * Room.BathsHeight * Convert.ToDouble(bathPayTxb_bath.Text);
                bathFinaleTxb_bath.Text = Room.Bath.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
