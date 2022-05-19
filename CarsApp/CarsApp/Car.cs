using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
//using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarsApp
{
    public class Car : INotifyPropertyChanged
    {
        private int _year;
        private string _make;
        private int _speed;

        private int _tirePressure;

        private Color _colour;



        public event PropertyChangedEventHandler PropertyChanged;

        //    public event PropertyChangedEventHandler PropertyChanged;

        private string _imageName;

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value;

                OnPropertyChanged();
            }
        }

        public Color Colour
        {
            get { return _colour; }
            set
            {
                _colour = value;
                OnPropertyChanged();
            }
        }

        public Car()
        {
            this._year = 1994;
            this._make = "Ford";
            this._speed = 0;

            Console.WriteLine("");
        }

        public Car(int year, string make, int speed, string imageName, Color colour)
        {
            _year = year;
            _make = make;
            _speed = speed;
            _imageName = imageName;
            _colour = colour;
        }

        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;

                OnPropertyChanged();
            }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value;
                OnPropertyChanged();
            }
        }

        public int Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
           
        }

        public void DriveFaster(int increment)
        {
            Speed += increment;

        }
        public void DriveSlower(int increment)
        {
            Speed -= increment;
        }


        public string GetMake()
        {
            return _make;
        }

        public void SetMake(string make)
        {
            _make = make;
        }

        public int GetTirePressure()
        {
            return _tirePressure;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
