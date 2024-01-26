namespace AbstractMethodsEx.Entities
{
    internal class Company : Taxes
    {
        public int EmployeeNumber { get; set; }

        public Company() { }
        public Company(string name, double anualIncome, int employeeNumber) : base (name, anualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double Total()
        {
            if (EmployeeNumber <= 10)
            {
                return AnualIncome * 0.16;
            } 
            else
            {
                return AnualIncome * 0.14;
            }
            
        }
    }
}
