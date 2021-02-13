namespace CoffeeMaker.Abstractions
{
    public abstract class HotWaterProvider
    {
        private bool _isBrewing;
        private WarmCoffeeContainer _warmCoffeeContainer;
        private UserInterface _userInterface;

        public void Init(WarmCoffeeContainer container, UserInterface userInterface)
        {
            _warmCoffeeContainer = container;
            _userInterface = userInterface;
        }

        public void StartBrewing()
        {
            _isBrewing = true;
            Brew();
        }

        public void Done()
        {
            _isBrewing = false;
        }

        public void DeclareDone()
        {
            _userInterface.Done();
            _warmCoffeeContainer.Done();
        }

        public abstract bool IsReady();
        public abstract void Brew();
        public abstract void Pause();
        public abstract void Resume();

    }
}