using CoffeeMaker.Abstractions;
using CoffeeMaker.HardwareApi;

namespace CoffeeMaker.Concretes
{
    public class M4WarmCoffeeContainer : WarmCoffeeContainer
    {
        private ICoffeeMakerAPI _coffeeMakerApi;
        private bool _isBrewing;

        public M4WarmCoffeeContainer(ICoffeeMakerAPI coffeeMakerApi)
        {
            _coffeeMakerApi = coffeeMakerApi;
        }

        public override bool IsReady()
        {
            return _coffeeMakerApi.GetWarmerPlateStatus() == WarmerPlateStatus.PotEmpty;

        }

        public override void Start()
        {
            _isBrewing = true;
        }
    }
}