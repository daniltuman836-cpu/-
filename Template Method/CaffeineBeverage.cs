namespace Template_Method
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected void BoilWater()
        {
            Console.WriteLine("Кипятим воду");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Наливаем в чашку");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();
    }

}
