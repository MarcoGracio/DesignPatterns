using System;
using System.Collections.Generic;

namespace ObservablePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var weahterstation = new WeatherStation();

            var phoneDisplay = new PhoneDisplay(weahterstation);
            var windowsDisplay = new WindowsDisplay(weahterstation);

            weahterstation.Add(phoneDisplay);
            weahterstation.Add(windowsDisplay);

            weahterstation.Notify();
            Console.ReadLine();
        }
    }

    interface IObservable
    {
        void Add(IObserver observer);
        void Notify();

        string GetTemperature();
    }

    public class WeatherStation : IObservable
    {
        List<IObserver> observers =  new List<IObserver>();

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public string GetTemperature()
        {
            return " Temperature X!!";
        }

        public void Notify()
        {
            foreach (var obs in observers)
            {
                obs.Refresh();
            }
        }
    }

    public interface IObserver
    {
        void Refresh();
    }

    public class PhoneDisplay : IObserver
    {
        private WeatherStation weatherStation;
        public PhoneDisplay(WeatherStation wd)
        {
            this.weatherStation = wd;
        }

        public void Refresh()
        {
            Console.WriteLine("Refresh phone display: " + weatherStation.GetTemperature());
        }
    }

    public class WindowsDisplay : IObserver
    {
        private WeatherStation weatherStation;
        public WindowsDisplay(WeatherStation wd)
        {
            weatherStation = wd;
        }
        public void Refresh()
        {
            Console.WriteLine("Refresh windows display" + weatherStation.GetTemperature());
        }
    }
}
