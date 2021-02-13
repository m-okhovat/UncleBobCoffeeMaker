namespace CoffeeMaker.Abstractions
{
    public abstract class HotWaterProvider
    {
        public abstract bool IsReady();

        public abstract void Start();
    }
}