using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ForKatya
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


        private void OpenLoveWindow(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Text == "я люблю машу")
            {
                MessageBox.Show("умница<3 я тебя тоже люблю!!!");
                LoveWindow loveWindow = new LoveWindow();
                loveWindow.Show();
            }
            else
            {
                MessageBox.Show("ты пыталась:( попробуй еще!", "ну же!!");
            }
        }
    }
}