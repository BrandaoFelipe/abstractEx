

namespace AbstractMethodsEx.Entities
{
    internal class Individual : Taxes
    {
        public double HealthExp { get; set; }

        public Individual() { }
        public Individual(string name, double anualIncome, double healthExp) : base(name, anualIncome)
        {
            HealthExp = healthExp;
        }

        public override double Total()
        {
            if (AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HealthExp * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExp * 0.5);
            }
             
        }
    }
}
