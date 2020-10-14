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
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }

        public void ChangeGears(bool isChanged)
        {
            Console.WriteLine($"{GetType().Name}");
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name}");
        }

        public void HasChangeGears(bool isChanged)
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
