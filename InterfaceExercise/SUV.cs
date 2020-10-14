using System;
namespace InterfaceExercise
{
    //In each of your car, truck, and suv classes

    /*Create 2 members that are specific to each class
     * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     * 
     */
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public string CompanyName { get; set; }
        public string Motto { get; set; }

        public void ChangeGears(bool isChanged)
        {
            Console.WriteLine();
        }

        public void Drive()
        {
            Console.WriteLine();
        }

        public void Park()
        {
            Console.WriteLine();
        }

        public void Reverse()
        {
            Console.WriteLine();
        }
    }
}
