using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public Suv()
        {
        }


        public double EngineSize { get; set; } = 7;
        public string Make { get; set; } = "GT";
        public string Model { get; set; } = "SUV";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Mercedes";
        public string Motto { get; set; } = "Generic Mercedes Motto";
        public bool HasChangedGears { get; set; }
        public bool HasCargoHold { get; set; }

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

        //public void CargoHold(bool hasHold)
        //{
        //    HasCargoHold = hasHold;
        //}




    }
}
