namespace Ovning1
{
    internal class EmployeeRegister
    {
        private readonly List<Employee> employeeList = [];

        public void DisplayRegister()
        {

            for (int index = 0; index < employeeList.Count; index++)
            {
                Console.WriteLine($"index: {index}, {employeeList[index]}");
            }

        }

        public void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }

        public void RemoveEmployee(int index)
        {
            if (index >= 0 && index < employeeList.Count)
            {
                employeeList.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }






    }
}
