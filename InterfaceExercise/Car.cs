using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "M";
        public string Model { get; set; } = "Generic Model";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Generic Motto";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }

        public void Park()
        {

            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} can't park until we change gears.");
            }
        }

        public void Rverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} can't reverse until we change gears.");
            }

        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }


    }
}
