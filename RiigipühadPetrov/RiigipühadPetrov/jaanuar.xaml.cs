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
    public partial class jaanuar : ContentPage
    {
        public jaanuar()
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
            Label nimetus = new Label { Text = "Январь", FontSize = 30 };
            Image img = new Image { Source = "jaanuar.jpg" };
            Label kirjeldus = new Label { Text = "первый месяц года в юлианском и григорианском календарях, одиннадцатый месяц староримского года, начинавшегося до реформы Цезаря с марта. Один из семи месяцев длиной в 31 день. Это, в среднем, самый холодный месяц года " };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Праздник в январе: 1 января - Новый год!", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}