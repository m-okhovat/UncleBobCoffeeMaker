using CoffeeMaker.Concretes;
using CoffeeMaker.HardwareApi;

namespace CoffeeMaker.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeMakerApi = new CoffeeMakerApi();
            var m4HotWaterProvider = new M4HotWaterProvider(coffeeMakerApi);
            var m4WarmCoffeeContainer = new M4WarmCoffeeContainer(coffeeMakerApi);
            var m4CoffeeMakerUserInterface = new M4CoffeeMakerUserInterface(coffeeMakerApi);

            m4CoffeeMakerUserInterface.Init(m4HotWaterProvider, m4WarmCoffeeContainer);

            while (true)
            {
                m4CoffeeMakerUserInterface.Poll();
            }
        }

    }
}
