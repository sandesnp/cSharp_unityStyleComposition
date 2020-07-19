using System;
using unityComposition.shutleSpeed;
using unityComposition.shuttleColor;

namespace unityComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            shuttleObject fastRedBike = new shuttleObject(new red(), new bike(), new fast());
            fastRedBike.whatType();
            fastRedBike.whatColor();
            fastRedBike.whatSpeed();
            shuttleObject fastRedCar = new shuttleObject(new red(), new car(), new fast());
            fastRedCar.whatTypeColorSpeed();
            shuttleObject slowBlueCar = new shuttleObject(new blue(), new car(), new slow());
            slowBlueCar.whatTypeColorSpeed();
            Console.ReadLine();
        }
    }
}
