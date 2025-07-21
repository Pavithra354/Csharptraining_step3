using System;

namespace PhoneSystem
{
    // Original SmartPhone class
    public class SmartPhone
    {
        public string Brand { get; set; }

        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber} from {Brand} smartphone");
        }
    }

    // Extension methods for SmartPhone
    public static class SmartPhoneExtensions
    {
        public static void TrackFitness(this SmartPhone phone)
        {
            Console.WriteLine($"The {phone.Brand} smartphone is tracking fitness now.");
        }

        public static void PlayGame(this SmartPhone phone, string gameName)
        {
            Console.WriteLine($"Playing {gameName} on the {phone.Brand} smartphone.");
        }

        // Additional Example Extension Method
        public static void TakePhoto(this SmartPhone phone)
        {
            Console.WriteLine($"Taking photo with {phone.Brand} smartphone.");
        }
    }

    // Program to demonstrate extension methods
    public class Program
    {
        public static void Main()
        {
            SmartPhone myPhone = new SmartPhone { Brand = "Apple" };

            myPhone.MakeCall("8328092935");
            myPhone.TrackFitness();
            myPhone.PlayGame("Cricket");
            myPhone.TakePhoto();

            Console.WriteLine("All smartphone tasks completed.");
        }
    }
}
