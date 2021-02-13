using CoffeeMaker.Abstractions;
using CoffeeMaker.HardwareApi;

namespace CoffeeMaker.Concretes
{
    public class M4CoffeeMakerUserInterface : UserInterface, IPollAble
    {
        private ICoffeeMakerAPI _coffeeMakerApi;

        public M4CoffeeMakerUserInterface(ICoffeeMakerAPI coffeeMakerApi)
        {
            _coffeeMakerApi = coffeeMakerApi;
        }


        public override void CompleteCycle()
        {
            _coffeeMakerApi.SetIndicatorState(IndicatorState.Off);
        }

        public override void Done()
        {
            _coffeeMakerApi.SetIndicatorState(IndicatorState.On);
        }

        private void CheckBrewButtonStatus()
        {
            var brewButtonStatus = _coffeeMakerApi.GetBrewButtonStatus();
            if (brewButtonStatus == BrewButtonStatus.Pushed)
                Brew();
        }

        public void Poll()
        {
            CheckBrewButtonStatus();
        }
    }

}
