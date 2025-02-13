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
        private MediaPlayer mediaPlayer = new MediaPlayer();
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
                string musicFilePath = "Images/net-idi-na.mp3";
                PlayMusic(musicFilePath);
                MessageBox.Show("ты пыталась:( попробуй еще!", "ну же!!");
            }
        }

        private void PlayMusic(string musicFilePath)
        {
            try
            {
                mediaPlayer.Open(new Uri(musicFilePath, UriKind.Relative));
                mediaPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке музыки: {ex.Message}");
            }
        }
    }
}