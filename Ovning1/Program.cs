
namespace Ovning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegister register = new();
            bool running = true;
            while (running)
            {
                Console.WriteLine("1 Add new employee");
                Console.WriteLine("2 Remove employee");
                Console.WriteLine("3 Print register");
                Console.WriteLine("4 Quit");
                Console.Write("Enter command: ");


                if (int.TryParse(Console.ReadLine(), out int command))
                {
                    switch (command)
                    {
                        case 1:
                            Console.Write("Enter employee name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter employee salary: ");
                            if (double.TryParse(Console.ReadLine(), out double salary))
                            {
                                register.AddEmployee(new Employee(name, salary));
                            }
                            else
                            {
                                Console.WriteLine("Invalid salary input");
                            }
                            break;

                        case 2:
                            Console.Write("Enter employee index: ");
                            if (int.TryParse(Console.ReadLine(), out int index))
                            {
                                register.RemoveEmployee(index);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                            break;

                        case 3:
                            register.DisplayRegister();
                            break;

                        case 4:
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Unknown command");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                Console.WriteLine();
            }
        }
    }

}
