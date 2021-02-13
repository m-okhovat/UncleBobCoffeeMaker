using CoffeeMaker.Abstractions;
using CoffeeMaker.HardwareApi;

namespace CoffeeMaker.Concretes
{
    public class M4HotWaterProvider : HotWaterProvider
    {
        private readonly ICoffeeMakerAPI _coffeeMakerApi;

        public M4HotWaterProvider(ICoffeeMakerAPI coffeeMakerApi)
        {
            _coffeeMakerApi = coffeeMakerApi;
        }

        public override bool IsReady()
        {
            return _coffeeMakerApi.GetBoilerStatus() == BoilerStatus.NotEmpty;
        }

        public override void Start()
        {
            _coffeeMakerApi.SetReliefValveState(ReliefValveState.Closed);
            _coffeeMakerApi.SetBoilerState(BoilerState.On);
        }
    }
}

