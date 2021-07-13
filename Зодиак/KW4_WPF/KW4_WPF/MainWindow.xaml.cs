using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KW4_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Properties.Resources resources = new Properties.Resources();
        private int i = 0;
        private List<Sign> signs = new List<Sign>();
        private Sign sign;
        public MainWindow()
        {
            InitializeComponent();
            InitSings();


        }


        void InitSings()
        {
            signs.Add(new Sign
            {
                Name = "Capricorn",
                Description = "Capricorn is a sign that represents time and responsibility, and its representatives are traditional and often very serious by nature. These individuals possess an inner state of independence that enables significant progress both in their personal and professional lives.",
                Planet = "Saturn",
                From = new DateTime(2019, 12, 22),
                To = new DateTime(2020, 01, 19),
                Picture = new BitmapImage(new Uri(@"Icons\Capricorn.png", UriKind.Relative))

            });
            signs.Add(new Sign
            {
                Name = "Taurus",
                Description = "Practical and well-grounded, Taurus is the sign that harvests the fruits of labor. They feel the need to always be surrounded by love and beauty, turned to the material world, hedonism, and physical pleasures.",
                Planet = "Venus",
                From = new DateTime(2020, 04, 21),
                To = new DateTime(2020, 05, 20),
                Picture = new BitmapImage(new Uri(@"Icons\Taurus.png", UriKind.Relative))
            });
            signs.Add(new Sign
            {
                Name = "Aries",
                Description = "As the first sign in the zodiac, the presence of Aries always marks the beginning of something energetic and turbulent.",
                Planet = "Mars",
                From = new DateTime(2020, 03, 21),
                To = new DateTime(2020, 04, 20),
                Picture = new BitmapImage(new Uri(@"Icons\Aries.png", UriKind.Relative))
            });

            signs.Add(new Sign
            {
                Name = "Sagittarius",
                Description = "Curious and energetic, Sagittarius is one of the biggest travelers among all zodiac signs. ",
                Planet = "Jupiter",
                From = new DateTime(2020, 11, 23),
                To = new DateTime(2020, 12, 21),
                Picture = new BitmapImage(new Uri(@"Icons\Sagittarius.png", UriKind.Relative))
            });


            signs.Add(new Sign
            {
                Name = "Leo",
                Description = "People born under the sign of Leo are natural born leaders. They are dramatic, creative, self-confident, dominant and extremely difficult to resist.",
                Planet = "Sun",
                From = new DateTime(2020, 07, 23),
                To = new DateTime(2020, 08, 22),
                Picture = new BitmapImage(new Uri(@"Icons\Leo.png", UriKind.Relative))
            });
            signs.Add(new Sign
            {
                Name = "Libra",
                Description = "People born under the sign of Libra are peaceful, fair, and they hate being alone. Partnership is very important for them, as their mirror and someone giving them the ability to be the mirror themselves.",
                Planet = "Venus",
                From = new DateTime(2020, 09, 23),
                To = new DateTime(2020, 10, 22),
                Picture = new BitmapImage(new Uri(@"Icons\Libra.png", UriKind.Relative))
            });
            signs.Add(new Sign
            {
                Name = "Gemini",
                Description = "Expressive and quick-witted, Gemini represents two different personalities in one and you will never be sure which one you will face. They are sociable, communicative and ready for fun, with a tendency to suddenly get serious, thoughtful and restless.",
                Planet = "Mercury",
                From = new DateTime(2020, 05, 21),
                To = new DateTime(2020, 06, 20),
                Picture = new BitmapImage(new Uri(@"Icons\Gemini.png", UriKind.Relative))
            });
            signs.Add(new Sign
            {
                Name = "Aquarius",
                Description = "Aquarius-born are shy and quiet , but on the other hand they can be eccentric and energetic. However, in both cases, they are deep thinkers and highly intellectual people who love helping others.",
                Planet = "Saturn",
                From = new DateTime(2020, 01, 20),
                To = new DateTime(2020, 02, 19),
                Picture = new BitmapImage(new Uri(@"Icons\Aquarius.png", UriKind.Relative))
            });


            signs.Add(new Sign
            {
                Name = "Scorpio",
                Description = "Scorpio-born are passionate and assertive people. They are determined and decisive, and will research until they find out the truth. Scorpio is a great leader, always aware of the situation and also features prominently in resourcefulness.",
                Planet = "Mars",
                From = new DateTime(2020, 10, 23),
                To = new DateTime(2020, 11, 22),
                Picture = new BitmapImage(new Uri(@"Icons\Scorpio.png", UriKind.Relative))
            });
            signs.Add(new Sign
            {
                Name = "Pisces",
                Description = "Pisces are very friendly, so they often find themselves in a company of very different people. Pisces are selfless, they are always willing to help others, without hoping to get anything back.",
                Planet = "Neptune",
                From = new DateTime(2020, 02, 20),
                To = new DateTime(2020, 03, 20),
                Picture = new BitmapImage(new Uri(@"Icons\Pisces.png", UriKind.Relative))
            });
            signs.Add(new Sign
            {
                Name = "Cancer",
                Description = "Deeply intuitive and sentimental, Cancer can be one of the most challenging zodiac signs to get to know. They are very emotional and sensitive, and care deeply about matters of the family and their home.",
                Planet = "Moon",
                From = new DateTime(2020, 06, 21),
                To = new DateTime(2020, 07, 22),
                Picture = new BitmapImage(new Uri(@"Icons\Cancer.png", UriKind.Relative))
            });
            signs.Add(new Sign
            {
                Name = "Virgo",
                Description = "Virgos are always paying attention to the smallest details and their deep sense of humanity makes them one of the most careful signs of the zodiac. Their methodical approach to life ensures that nothing is left to chance, and although they are often tender, their heart might be closed for the outer world.",
                Planet = "Mercury",
                From = new DateTime(2020, 08, 23),
                To = new DateTime(2020, 09, 22),
                Picture = new BitmapImage(new Uri(@"Icons\Virgo.png", UriKind.Relative))
            });
            // signs.Sort((s1, s2) => DateTime.Compare(s1.From, s2.From));

            signs.First(s => s.Name == "Aries").CompatibleSigns.Add("Gemini");
            signs.First(s => s.Name == "Aries").CompatibleSigns.Add("Leo");
            signs.First(s => s.Name == "Aries").CompatibleSigns.Add("Sagittarius");
            signs.First(s => s.Name == "Aries").CompatibleSigns.Add("Aquarius");

            signs.First(s => s.Name == "Taurus").CompatibleSigns.Add("Cancer");
            signs.First(s => s.Name == "Taurus").CompatibleSigns.Add("Virgo");
            signs.First(s => s.Name == "Taurus").CompatibleSigns.Add("Capricorn");
            signs.First(s => s.Name == "Taurus").CompatibleSigns.Add("Pisces");

            signs.First(s => s.Name == "Gemini").CompatibleSigns.Add("Aries");
            signs.First(s => s.Name == "Gemini").CompatibleSigns.Add("Leo");
            signs.First(s => s.Name == "Gemini").CompatibleSigns.Add("Libra");
            signs.First(s => s.Name == "Gemini").CompatibleSigns.Add("Aquarius");

            signs.First(s => s.Name == "Cancer").CompatibleSigns.Add("Taurus");
            signs.First(s => s.Name == "Cancer").CompatibleSigns.Add("Virgo");
            signs.First(s => s.Name == "Cancer").CompatibleSigns.Add("Scorpio");
            signs.First(s => s.Name == "Cancer").CompatibleSigns.Add("Pisces");





        }

        SoundPlayer soundPlayer = new SoundPlayer();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          //  soundPlayer.SoundLocation = @"music.wav";


            //try
            //{
            //    soundPlayer.LoadAsync();
            //    soundPlayer.PlayLooping();
            //}
            //catch (FileNotFoundException exc)
            //{
            //    MessageBox.Show(exc.Message);

            //}
            //catch (FormatException exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}
        }


        //Get Zodiac Sign 
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            if (DayBox.SelectedItem != null && MonthBox.SelectedItem != null) {
                int day = 13;// Convert.ToInt32(DayBox.SelectedItem.ToString());
                int month = 7;//Convert.ToInt32(MonthBox.SelectedItem.ToString());
                DateTime date = DateTime.Now;

                try
                {
                    date = new DateTime(2020, month, day);
                    sign=signs.FirstOrDefault(x => x.From <= date && x.To >= date);
                    imgSign.Source = sign.Picture;
                   // myImage.Source = myBitmapImage;
                    //foreach (var item in signs)
                    //{
                    //    if (item.From <= date && item.To >= date) {
                    //        sign = item;
                    //    }
                    //}


                }
                catch (Exception)
                {

                    MessageBox.Show("Дата выбрана не корректно!");
                }

            }

        }
    }
}
