using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace App13
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        public string telefon { get; private set; }

        List<Dersler> liste = new List<Dersler>();
        List<Derslik> liste1 = new List<Derslik>();
        List<Hocalar> liste2 = new List<Hocalar>();



        public HomePage()
        {
            InitializeComponent();
            ListeDoldur(liste);
            listDersler.BindingContext = liste;
            ListeDoldur(liste1);
            listDerslik.BindingContext = liste1;
            ListeDoldur(liste2);
            listHocalar.BindingContext = liste2;

        }
        void OpenBrowser(string url)
        {
            Device.OpenUri(new Uri(url));
        }
        public async void HandleTapped(object sender, EventArgs e)
        {
            var args = (TappedEventArgs)e;
            var myObject = args.Parameter;
            await DisplayAlert("Alert", myObject.ToString(), "Ok!");
        }

        public void ListeDoldur(List<Dersler> list)
        {
            list.Add(new Dersler
            {
                DersKodu = "BIM493",
                DersAdı = "- Mobil Programlama I",
            });
            list.Add(new Dersler
            {
                DersKodu = "BIM466",
                DersAdı = "- Bulanık Mantık",

            });
            list.Add(new Dersler
            {
                DersKodu = "BIM451",
                DersAdı = "- MVC ile Web Sunucu Programlama",
            });
            list.Add(new Dersler
            {
                DersKodu = "BIM309",
                DersAdı = "- Yapay Us",
            });
            list.Add(new Dersler
            {
                DersKodu = "BIM101",
                DersAdı = "- Bilgisayar Programlama I",
            });
            list.Add(new Dersler
            {
                DersKodu = "BIM437",
                DersAdı = "- Bilgisayar Mühendisliği Tasarımları",
            });

        }

        public void ListeDoldur(List<Derslik> list)
        {
            list.Add(new Derslik
            {
                DerslikAdı = "Derslik-B1",
                Kapasite = "Kapasite: 36",
                ImageUrl = "Class_B1.jpg"

            });
            list.Add(new Derslik
            {
                DerslikAdı = "Derslik-B2",
                Kapasite = "Kapasite: 15",
                ImageUrl = "Class_B2.jpg"



            });
            list.Add(new Derslik
            {
                DerslikAdı = "Derslik-B3",
                Kapasite = "Kapasite: 18",
                ImageUrl = "Class_B3.jpg"


            });
            list.Add(new Derslik
            {
                DerslikAdı = "Derslik-B4",
                Kapasite = "Kapasite: 24",
                ImageUrl = "Class_B4.jpg"


            });
            list.Add(new Derslik
            {
                DerslikAdı = "Derslik-B5",
                Kapasite = "Kapasite: 15",
                ImageUrl = "Class_B6.jpg"



            });
            list.Add(new Derslik
            {
                DerslikAdı = "Derslik-B6",
                Kapasite = "Kapasite: 24",
                ImageUrl = "Class_B6.jpg"


            });
            list.Add(new Derslik
            {
                DerslikAdı = "Derslik-B7",
                Kapasite = "Kapasite: 54",
                ImageUrl = "Class_B7.jpg"


            });


        }
        public void ListeDoldur(List<Hocalar> list)
        {
            list.Add(new Hocalar
            {
                HocaAdı = "Dr.Öğr. Üyesi Ahmet ARSLAN Bölüm Başkanı",
                mail = "E-Mail: aarslan2@eskisehir.edu.tr",
                telefon = "5555555559",
                ImageFoto = "aarslan.jpg"
            });;
            list.Add(new Hocalar
            {
                HocaAdı = "Prof.Dr.Yaşar HOŞCAN",
                mail = "E-Mail: hoscan@eskisehir.edu.tr",
                telefon = "5555555558",
                ImageFoto = "yhoscan.jpg"
            });
            list.Add(new Hocalar
            {
                HocaAdı = "Prof.Dr. Serkan GÜNAL",
                mail = "E-Mail: serkangunal@eskisehir.edu.tr",
                telefon = "5555555557",
                ImageFoto = "serkangunal.jpg"
            });
            list.Add(new Hocalar
            {
                HocaAdı = "Doç.Dr. Cihan KALELİ",
                mail = "E-Mail: ckaleli@eskisehir.edu.tr",
                telefon = "5555555556",
                ImageFoto = "ckaleli.jpg"
            });
            list.Add(new Hocalar
            {
                HocaAdı = "Doç.Dr. Alper Kürşat UYSAL",
                mail = "E-Mail: akuysal@eskisehir.edu.tr",
                telefon = "5555555555",
                ImageFoto = "akuysal.jpg"
            });
            list.Add(new Hocalar
            {
                HocaAdı = "Doç.Dr. Alper BİLGE",
                mail = "E-Mail: abilge@eskisehir.edu.tr",
                telefon = "5555555554",
                ImageFoto = "abilge.jpg"
            });
            list.Add(new Hocalar
            {
                HocaAdı = "	Dr.Öğr. Üyesi Sevcan YILMAZ GÜNDÜZ",
                mail = "E-Mail: sevcany@eskisehir.edu.tr",
                telefon = "5555555553",
                ImageFoto = "sevcany.jpg"
            });

            list.Add(new Hocalar
            {
                HocaAdı = "Dr.Öğr. Üyesi Burcu YÜREKLİ YILMAZEL",
                mail = "E-Mail: byurekli@eskisehir.edu.tr",
                telefon = "5555555552",
                ImageFoto = "byurekli.jpg"
            });
            list.Add(new Hocalar
            {
                HocaAdı = "Öğr.Gör. Özgür ÖZŞEN Bölüm Staj Koord.",
                mail = "E-Mail: oozsen@eskisehir.edu.tr",
                telefon = "5555555551",
                ImageFoto = "oozsen.jpg"
            });
            list.Add(new Hocalar
            {
                HocaAdı = "Öğr.Gör. Emre KAÇMAZ",
                mail = "E-Mail: emrekacmaz@eskisehir.edu.tr",
                telefon = "5555555550",
                ImageFoto = "ekacmaz.jpg"
            });

        }
  

        /** public void CallButtonClicked(){

            var CallButton = new Style(typeof(Button))
            {
                Setters = {
      
                    new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex ("#eee") },     
                    new Setter { Property = Button.TextColorProperty, Value = Color.Black },
                    new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
                    new Setter { Property = Button.FontSizeProperty, Value = 40 }
    }
            };

            var controlGrid = new Grid { RowSpacing = 1, ColumnSpacing = 1 };
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(150) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });


            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 0, 0);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 1, 0);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 2, 0);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 3, 0);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 4, 0);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 5, 0);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 0, 1);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 1, 1);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 2, 1);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 3, 1);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 4, 1);
            controlGrid.Children.Add(new Button { Text = "Call", Style = CallButton }, 5, 1);

        }**/
    }
}