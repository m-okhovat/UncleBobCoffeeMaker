namespace CoffeeMaker.Abstractions
{
    public abstract class WarmCoffeeContainer
    {

        public abstract bool IsReady();

        public abstract void Start();

        public void Done()
        {
            throw new System.NotImplementedException();
        }
    }
}