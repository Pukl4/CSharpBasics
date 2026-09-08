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
        private string _brand = "";
        private string _model = "";
        private int _year = 0;

        // Constructor is a code with the same name as a class
        // and it is automatically called when an object of a class is created.
        public Car(string brand, string model, int year)
        {
            _brand = brand;
            _model = model;
            _year = year;
            Console.WriteLine(_brand + ", " + _model + ", " + _year);
        }
    }
}
