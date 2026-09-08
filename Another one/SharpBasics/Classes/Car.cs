using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Classes
{
    public class Car
    {
       //private modifier means that something can only be accessed from within
       //the class where it is declared.
        private string _brand = string.Empty;
        private string _model = string.Empty;
        private int _year = 0;

        // Constructor is a code with the same name as a class
        // and it is automatically called when an object of a class is created.
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Console.WriteLine(Brand + ", " + Model + ", " + Year);
        }

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model;
            set { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty");
                }
                _model = value;
            }
        }
        public int Year { get => _year; set => _year = value; }
    }
}
