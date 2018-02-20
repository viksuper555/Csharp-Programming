using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _8thapp
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var kilometers = double.Parse(Console.ReadLine());
            var travelTime = Console.ReadLine();
            var taxiStartPrice = 0.7;
            var taxiDailyPrice = 0.79;
            var taxiNightPrice = 0.9;
            var busPrice = 0.09;
            var trainPrice = 0.06;

            var currentTotalPrice = 0.0;
            //Train
            if (kilometers >= 100)
                currentTotalPrice = trainPrice * kilometers;
            //Bus
            else if (kilometers >= 20)
                currentTotalPrice = busPrice * kilometers;
            //Taxi
            if (travelTime == "day")
            {
                currentTotalPrice = taxiStartPrice + kilometers * taxiDailyPrice;
            }
            else
            {
                currentTotalPrice = taxiStartPrice + kilometers * taxiNightPrice;
            }
            Console.WriteLine($"{currentTotalPrice:f2}");
        }
    }
}
