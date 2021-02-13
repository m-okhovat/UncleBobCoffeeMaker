namespace CoffeeMaker.Abstractions
{
    public abstract class UserInterface
    {

        private HotWaterProvider _hotWaterProvider;
        private WarmCoffeeContainer _warmCoffeeContainer;

        public void Init(HotWaterProvider hotWaterProvider, WarmCoffeeContainer warmCoffeeContainer)
        {
            _hotWaterProvider = hotWaterProvider;
            _warmCoffeeContainer = warmCoffeeContainer;
        }

        protected void Brew()
        {
            if (_hotWaterProvider.IsReady() && _warmCoffeeContainer.IsReady())
            {
                _hotWaterProvider.Start();
                _warmCoffeeContainer.Start();
            }
        }

        public abstract void Complete();
        public abstract void Done();
    }
}
