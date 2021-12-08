using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace InnaSuk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, User!");
            Console.WriteLine("Please, enter the number of the employees, you are going to put here: ");
            int selection = Control.OnlyInteger(Console.ReadLine());
            string name;
            int subordinateQuantity;

            List<Employee> new_employees = new List<Employee>();

            for(int e = 0; e < selection; e++)
            {
                Console.WriteLine("Please, enter the number of position you want to add:\n 1_Chairman\n 2_Assistant\n 3_Secretary\n 4_Accountant\n 5_SalesManager\n 6_CallOperator");
            int choice = Control.OnlyInteger(Console.ReadLine());
                while(choice < 1 || choice > 6)
                {
                    Console.WriteLine(" Sorry, but you need to choose from 1 to 6 number: ");
                    choice = Control.OnlyInteger(Console.ReadLine());
                }
                
                Console.WriteLine("Ok, let's continue! Please, enter the new employee's name:");
                name = Console.ReadLine();
                Console.WriteLine($"Ok, the new employee's name is {name} !");
          
                Console.WriteLine($"Will {name} have subordinates? If yes, then enter the number of it, if no - enter 0  ");
                subordinateQuantity = Control.OnlyInteger2(Console.ReadLine());
                MakeNew.MakeNewEmployee(selection, name, subordinateQuantity, new_employees);

            }
            Console.WriteLine("Thank you! You just added a new employee to the system! Do you want to watch the information about employee? Press 1 if yes, no - another symbol");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Here is a list of employees:");
                foreach (Employee employee in new_employees)
                {
                    Console.WriteLine(employee.Name());
                }
                Console.WriteLine("If you want to watch some information about the employee, you write the name. Please write the name: ");
                name = Console.ReadLine();
                foreach (Employee employee in new_employees)
                {
                    if (name != employee.Name())
                    {
                        Console.WriteLine("This employee is not yet registrated into the system.");
                    }
                    else
                    {
                        Console.WriteLine($"A little about the {name}");
                    }

                }
                foreach(Employee employee in new_employees)
                {
                    if (name == employee.Name())
                    {
                        Console.WriteLine(" position: " + employee.Position());
                        Console.WriteLine(" name: " + employee.Name());
                        Console.WriteLine("quantity of subordinates: " + employee.Subordinate());
                        Console.WriteLine(" salary: " + employee.Salary());
                        Console.WriteLine("responsibility level: " + employee.ResponsibilityLevel());
                    }

                }

            }
                

        }
  
    }
}
