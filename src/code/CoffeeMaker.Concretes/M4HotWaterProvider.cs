using CoffeeMaker.Abstractions;
using CoffeeMaker.HardwareApi;

namespace CoffeeMaker.Concretes
{
    public class M4HotWaterProvider : HotWaterProvider, IPollAble
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

        public override void Brew()
        {
            _coffeeMakerApi.SetReliefValveState(ReliefValveState.Closed);
            _coffeeMakerApi.SetBoilerState(BoilerState.On);
        }

        public override void Pause()
        {
            throw new System.NotImplementedException();
        }

        public override void Resume()
        {
            throw new System.NotImplementedException();
        }

        public void Poll()
        {
            throw new System.NotImplementedException();
        }
    }
}

