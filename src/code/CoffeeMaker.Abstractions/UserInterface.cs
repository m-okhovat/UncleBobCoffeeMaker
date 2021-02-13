namespace CoffeeMaker.Abstractions
{
    public abstract class UserInterface
    {

        private HotWaterProvider _hotWaterProvider;
        private WarmCoffeeContainer _warmCoffeeContainer;
        private bool _isBrewingComplete;
        public void Init(HotWaterProvider hotWaterProvider, WarmCoffeeContainer warmCoffeeContainer)
        {
            _hotWaterProvider = hotWaterProvider;
            _warmCoffeeContainer = warmCoffeeContainer;
        }

        protected void Brew()
        {
            if (_hotWaterProvider.IsReady() && _warmCoffeeContainer.IsReady())
            {
                _hotWaterProvider.Brew();
                _warmCoffeeContainer.Start();
                _isBrewingComplete = false;
            }
        }

        public void Complete()
        {
            _isBrewingComplete = true;
            CompleteCycle();
        }

        public abstract void CompleteCycle();
        public abstract void Done();
    }
}
