using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Contracts
{
    public class Vehicle
    {
        private string _model { get; set; }
        private int _date { get; set; }
        private bool _isSecondHand { get; set; }
        public Vehicle(string model, int date, bool isSecondHand)
        {
            _model = model;
            _date = date;
            _isSecondHand = isSecondHand;
        }

        public string GetVehicleModel() => _model;
        public int GetVehicleDate() => _date;
        public bool GetVehicleIsSecondHand() => _isSecondHand;

    }
    public class Car : Vehicle, IDisposable
    {
        private char[] _segments = { 'A', 'B', 'C', 'D', 'E' };

        private char _sportSegment;
        private bool disposedValue;

        public Car(char sportSegment, string model, int date, bool isSecondHand) : base(model, date, isSecondHand)
        {
            SportSegment = sportSegment;
        }

        public char SportSegment
        {
            get => _sportSegment;
            set
            {
                _sportSegment = _segments.Any(p => p.Equals(value)) ? value : 'C';
            }
        }



        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~Car()
        {
            Console.WriteLine("finalizer çalıştı.");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
