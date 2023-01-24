namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            Quadcopter copter = new Quadcopter();                      

            foreach (var item in copter.GetComponents())
            {
                Console.WriteLine(item);
            }

            copter.Charge();

            Console.WriteLine(((IFlyingRobot)copter).GetRobotType());
        }
    }
}