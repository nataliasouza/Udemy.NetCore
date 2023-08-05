
using System.Globalization;

namespace curso.POO.ExerciciosSecao06
{
    public class Employee
    {      
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get;  private set; }
        public List<Employee> ListEmployees => listEmployees;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        private static List<Employee> listEmployees = new List<Employee>();

        public static void Executar()
        {
            Console.Write("How many employees will be registered?: ");
            int numberOfEmployees = int.Parse(Console.ReadLine()!);            
            RegisterEmployee(numberOfEmployees);

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee employeeId = listEmployees.Find(x => x.Id == searchId);
            if (employeeId != null)
            {
                Console.Write("\nEnter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeeId.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\n\tUpdated list of employees:");
            foreach (Employee name in listEmployees)
            {
                Console.WriteLine(name);
            }
        }

        public static void RegisterEmployee(int numberOfEmployees)
        {            

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("\nEmployee #" + (i + 1) + ":");
                Console.Write("Enter the Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter the Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter the Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                CreateEmployee(id,name,salary);
            }
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public static void CreateEmployee(int id, string name, double salary)
        {            
            listEmployees.Add(new Employee(id, name, salary));
        }
    }  
}
