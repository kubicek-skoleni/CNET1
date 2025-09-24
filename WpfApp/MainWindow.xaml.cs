using System.Globalization;
using System.Windows;
using Humanizer;

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

            Thread.CurrentThread.CurrentCulture = new CultureInfo("cs-CZ");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("cs-CZ");

        }

        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            coutner++;
            txbInfo.Text = coutner.ToWords(new CultureInfo("cs-CZ"));
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

        private void btnHumanizer_Click(object sender, RoutedEventArgs e)
        {
            var result = (new DateTime(2024, 6, 1, 12, 0, 0)).Humanize(culture: new CultureInfo("cs-CZ"));
                //DateTime.Now.AddHours(-1).Humanize(culture: new CultureInfo("cs-CZ"));
                //"student".ToQuantity(5) ;
            txbHumanizer.Text = result;
        }

        private void btnStudenForm_Click(object sender, RoutedEventArgs e)
        {
            var student_form = new StudentForm();
            student_form.Show();
        }
    }
}