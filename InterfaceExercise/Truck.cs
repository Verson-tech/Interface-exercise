using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle,ICompany
    {
        public Truck()
        {

        }
        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F150";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Generic Motto";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel  drive {GetType().Name} now driving forward...");
            }
            else
            {
                Console.WriteLine($"4 wheel  drive {GetType().Name} not driving forward...");
            }
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
