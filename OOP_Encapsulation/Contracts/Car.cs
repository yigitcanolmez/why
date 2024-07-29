using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation.Contracts
{
    public class Car
    {
        public string Brand { get; set; }
        public int Year { get; set; }

    }

    public class Car2
    {
        public Car2(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }
        public string Brand { get; set; }
        public int Year { get; set; }
    }

    public class Car3
    {
        private string _brand;

        private int _year;
        public Car3(string brand, int year)
        {
            _brand = brand == " " ? "BMW" : brand;
            _year = year < 2000 ? 2005 : year;
        }

        public string GetBrand() => _brand;
        public int GetYear() => _year;
    }

    public class Car4
    {
        private string _brand;

        private int _year;
        public Car4()
        {

        }
        public Car4(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }
        public string Brand
        {
            get => _brand;
            set
            {
                _brand = value == " " ? "BMW" : value;
            }
        }
        public int Year
        {
            get => _year;
            set
            {
                _year = value < 2000 ? 2005 : value;
            }
        }
    }
}
