using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiigipühadPetrov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class November : ContentPage
    {
        public November()
        {
            InitializeComponent();
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
            {
            new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
            new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
            new RowDefinition {Height=new GridLength(1,GridUnitType.Star)}
            },
                ColumnDefinitions =
            {
            new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }
            };
            Label nimetus = new Label { Text = "Ноябрь", FontSize = 30 };
            Image img = new Image { Source = "november.jpg" };
            Label kirjeldus = new Label { Text = "одиннадцатый месяц Григорианского календаря. Девятый месяц староримского года, начинавшегося до реформы Цезаря с марта. Название получил от лат. novem — девять. Один из четырёх месяцев длиной в 30 дней. Последний месяц календарной осени в Северном полушарии, весны в Южном. " };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Праздник в Ноябре: Ноябрь - международный день Науки!", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}