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
        private bool _isluxury = true;

        // Constructor is a code with the same name as a class
        // and it is automatically called when an object of a class is created.
        public Car(string brand, string model, int year, bool isLuxury)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Isluxury = isLuxury;
            Console.WriteLine(Brand + ", " + Model + ", " + Year);
        }

        public string Brand {
            get 
            {
                if(Isluxury == true)
                {
                    return _brand + " (Luxury one)";
                }
                else
                {
                    return _brand;
                }
            }
            set => _brand = value; }
        public string Model { get => _model;
            set { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty");
                }
                _model = value;
            }
        }

        // This property is with lambda expression, which is a shorthand way to define a property with a single expression.
        public int Year { get => _year; set => _year = value; }

        /* Non-simplified version of the Year property:
         * public int Year
         * {
         *      get { return _year; }
         *      set { _year = value; }
         * }
         */
        public bool Isluxury { get => _isluxury; set => _isluxury = value; }
    }
}
