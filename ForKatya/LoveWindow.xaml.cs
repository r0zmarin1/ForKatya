using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

namespace ForKatya
{
    /// <summary>
    /// Логика взаимодействия для LoveWindow.xaml
    /// </summary>
    public partial class LoveWindow : Window, INotifyPropertyChanged
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private Reason reason;
        private List<Reason> reasons;
        private int lovePoints = 0;


        public int LovePoints
        {
            get => lovePoints;
            set
            {
                lovePoints = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LovePoints)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        public Reason Reason
        {
            get => reason;
            set
            {
                reason = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Reason)));
            }
        }

        public List<Reason> Reasons
        {
            get => reasons;
            set
            {
                reasons = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Reasons)));
            }
        }

        public LoveWindow()
        {
            InitializeComponent();
            Reasons = new List<Reason>
            {
                new Reason
                {
                    Id=1, Number="Намбер 1", Title="катенька самая лучшая!!!", Description="я считаю кате надо подарить весь мир!!"
                },
                new Reason
                {
                    Id=2, Number="Намбер 2", Title="катенька хорошо играет в игры!!!", Description="поэтому я хочу играть вместе с ней и помогать ей!!"
                },
                new Reason
                {
                    Id=3, Number="Намбер 3", Title="катенька очень вкусно готовит!!!", Description="я готова приходить и кушать все что она приготовит!!"
                },
                new Reason
                {
                    Id=4, Number="Намбер 4", Title="катенька хорошо посылает плохих людей!!!", Description="поэтому я могу делиться с ней переживаниями и не бояться осуждения!!"
                },
                new Reason
                {
                    Id=5, Number="Намбер 5", Title="катенька очень красивая!!!", Description="поэтому я готова любоваться ей днями и ночами!!"
                }
            };
            DataContext = this;
        }


        private void ClickLove(object sender, RoutedEventArgs e)
        {
            string musicFilePath = "Images/rizz.mp3";
            PlayMusic(musicFilePath);
            LovePoints++;

        }

        private void ChooseValentine(object sender, MouseButtonEventArgs e)
        {
            string musicFilePath = "Images/hehehe.mp3";
            PlayMusic(musicFilePath);
            
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
