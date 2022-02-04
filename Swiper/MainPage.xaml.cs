using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swiper.Controls;
using Xamarin.Forms;

namespace Swiper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MainGrid.Children.Add(new SwiperControl());
        }
    }
}
