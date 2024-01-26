

namespace AbstractMethodsEx.Entities
{
    abstract class Taxes
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public Taxes() { }

        protected Taxes(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Total();
        

    }
}
