namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Boat boat = new Boat();
            Airplane airplane = new Airplane();
            car.ShowPoperties();
            boat.ShowPoperties();
            airplane.ShowPoperties();   
        }
    }
}