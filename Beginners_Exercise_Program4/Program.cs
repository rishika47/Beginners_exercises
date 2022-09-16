//4.Your job is to write a program for a speed camera.
//For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
//Write a program that asks the user to enter the speed limit.
//Once set, the program asks for the speed of a car.
//If the user enters a value less than the speed limit, program should display Ok on the console.
//If the value is above the speed limit, the program should calculate the number of demerit points.
//For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
//If the number of demerit points is above 12, the program should display License Suspended.
using System;
namespace Beginners_Exercise_Program4
{
    public static class CarSpeedLimit
    {
        public static void Main()
        {
            var demerit = 0;
            Console.WriteLine("Enter the speed limit value: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (speedLimit > carSpeed)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var extraSpeed = carSpeed - speedLimit;
                demerit = extraSpeed / 5;
                Console.WriteLine("Demerit : " +demerit);
            }
            if (demerit > 12)
            {
                
                Console.WriteLine("License Suspended");
            }
        }
    }
}