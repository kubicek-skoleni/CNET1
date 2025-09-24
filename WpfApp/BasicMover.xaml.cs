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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for BasicMover.xaml
    /// </summary>
    public partial class BasicMover : Window
    {
        double player_x = 50;
        double player_y = 50;
        double move_step = 10;

        public BasicMover()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.Key;

            switch (key)
            {
                case Key.Up:
                    player_y -= move_step;
                    break;
                case Key.Down:
                    player_y += move_step;
                    break;
                case Key.Left:
                    player_x -= move_step;
                    break;
                case Key.Right:
                    player_x += move_step;
                    break;
            }


            Canvas.SetLeft(Player, player_x);
            Canvas.SetTop(Player, player_y);
        }
    }
}
