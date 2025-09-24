using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int coutner = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            coutner++;
            txbInfo.Text = coutner.ToString();
        }

        private void btnBasicMover_Click(object sender, RoutedEventArgs e)
        {
            var mover_window = new BasicMover();
            mover_window.Show();
        }

        private void btnMainWindowLauch_Click(object sender, RoutedEventArgs e)
        {
            var new_window = new MainWindow();
            new_window.Show();
        }
    }
}