using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarDetailPage : ContentPage
    {
        private Car _car;
        public CarDetailPage(Car car)
        {
            InitializeComponent();

            _car = car;

            BindingContext = _car; 
        }

        private void DriveFasterButton_Clicked(object sender, EventArgs e)
        {
            _car.DriveFaster(45);

        }
    }
}