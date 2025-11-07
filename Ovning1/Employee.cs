namespace Ovning1
{
    internal class Employee
    {
        private string name;
        private double salary;

        public String Name { get; set; }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("salary can not be negative");
                salary = value;
            }
        }
        public override string ToString()
        {
            return $"{Name} has a salary of {Salary}";
        }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}