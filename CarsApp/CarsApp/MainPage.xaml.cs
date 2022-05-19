using System.Collections.Generic;
using Xamarin.Forms;

namespace CarsApp
{
    public partial class MainPage : ContentPage
    {
        private List<Car> _cars = new List<Car>();

        public List<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }


        public MainPage()
        {
            InitializeComponent();

            CreateCars();

            BindingContext = this;
        }

        public void CreateCars()
        {
            Car myCar = new Car(2003, "Jazz", 0, "jazz.png",Color.Red);
         //  myCar.Colour = "Red";
            myCar.DriveFaster(20);

            _cars.Add(myCar);

            Car angelsCar = new Car(2022, "Porsche", 0,"porche.png",Color.Pink);
         //   angelsCar.Colour = "Pink";
            angelsCar.DriveFaster(120);

            _cars.Add(angelsCar);
                      
            Car vw = new Car(2020, "Polo", 10,"polo.png",Color.Black);
            vw.DriveFaster(45);
            vw.Make = "Golf";

            _cars.Add(vw);

            Car bmw = new Car(2019, "M3", 0,"bmw.png",Color.Wheat);

            _cars.Add(bmw);

            Car rollsRoyce = new Car(2019, "Phantom", 0, "rolls.png",Color.Gold);

            _cars.Add(rollsRoyce);

            Car mazda = new Car(1989, "323", 0, "mazda.png", Color.Gray);

            _cars.Add(mazda);

            Car cresida = new Car(1973, "Cresida", 0, "cresida.png",Color.LightBlue);

            _cars.Add(cresida);
        }

        private async void CarsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Car car =  e.Item as Car;

            if (car != null)
            {
                await Navigation.PushAsync(new CarDetailPage(car));
            }
        }
    }
}
