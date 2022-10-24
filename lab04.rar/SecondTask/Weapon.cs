namespace SecondTask
{
    public abstract class Weapon
    {
        protected int damage;
        protected int condition;
        protected int price;

        public virtual int CalculateDamage()
        {
            return damage;
        }

        public virtual void Repair()
        {
            condition += 20;
        }

        public virtual int Sell()
        {
            return price;
        }

        public virtual void ShowMethods()
        {
            Console.WriteLine(GetType().Name);
            foreach (var method in GetType().GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
    }
}
