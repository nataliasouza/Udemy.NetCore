
using System.Globalization;

namespace curso.POO.ExerciciosSecao06
{
    public class Employee
    {      
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get;  private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public static void Executar()
        {
            List<Employee> listEmployees = new List<Employee>();
            Console.Write("How many employees will be registered?: ");
            int numberOfEmployees = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("\nEmployee #" + (i + 1) + ":");
                Console.Write("Enter the Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter the Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter the Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployees.Add(new Employee(id, name, salary));
            }           

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee employeeId = listEmployees.Find(x => x.Id == searchId);
            if (employeeId != null)
            {
                Console.Write("Enter the percentage: ");
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
    }  
}
