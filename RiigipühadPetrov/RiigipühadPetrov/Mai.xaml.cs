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
    public partial class Mai : ContentPage
    {
        public Mai()
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
            Label nimetus = new Label { Text = "Май", FontSize = 30 };
            Image img = new Image { Source = "mai.jpg" };
            Label kirjeldus = new Label { Text = " Пятый месяц года в юлианском и григорианском календарях, третий месяц староримского года, начинавшегося до реформы Цезаря с марта. Один из семи месяцев длиной в 31 день. " };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Праздник в мае: 9 мая - день победы!", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}