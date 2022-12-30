
namespace Interfaces
{
    public class Quadcopter : IChargeable, IFlyingRobot
    {
        private List<string> listComponents = new() { "rotor1", "rotor2", "rotor3", "rotor4" };

        public void Charge()
        {
            Console.Write("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public List<string> GetComponents()
        {
            return listComponents;
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
