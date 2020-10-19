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
    public partial class detsember : ContentPage
    {
        public detsember()
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
            Label nimetus = new Label { Text = "Декабрь", FontSize = 30 };
            Image img = new Image { Source = "detsember.jpg" };
            Label kirjeldus = new Label { Text = "двенадцатый месяц григорианского календаря. Десятый месяц староримского года, начинавшегося до реформы Цезаря с марта. После сдвига начала года на январь стал двенадцатым, последним месяцем года. Один из семи месяцев длиной в 31 день. В Южном полушарии Земли является месяцем лета, в Северном — зимы. У чехов раньше назывался «волчьим месяцем» " };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "Первый день зимы: 1 Декабря!", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}