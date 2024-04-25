using Microsoft.Identity.Client;

namespace Entity_Framework;

class Program
{
    static void Main(string[] args)
    {
        using var DbContext = new DemoContextDb();
        int choice = 0;
        while (choice !=3)
        {   
            System.Console.WriteLine("|------------------------------------------|");
            System.Console.WriteLine("|            Employees Database            |");
            System.Console.WriteLine("|------------------------------------------|");
            System.Console.WriteLine("| 1. Get employee details                  |");
            System.Console.WriteLine("| 2. Insert employee details               |");
            System.Console.WriteLine("| 3. EXIT                                  |");
            System.Console.WriteLine("|------------------------------------------|");
            System.Console.Write("Enter your number you want to perform: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    System.Console.WriteLine($"------------------------------------------------------------------------");
                    System.Console.WriteLine($"   ID   |   First Name   |   Last Name   |     State     |     City     ");
                    System.Console.WriteLine($"------------------------------------------------------------------------");
                    foreach (var item in DbContext.Employee)
                    {
                        System.Console.WriteLine($"     {item.Emp_Id}        {item.First_Name}          {item.Last_Name}          {item.State}         {item.City}    ");
                    }
                    System.Console.WriteLine($"------------------------------------------------------------------------");
                    break;

                case 2:
                    System.Console.WriteLine("Enter Employee Details.");
                    System.Console.Write("Enter Department ID: ");
                    int dId = Convert.ToInt32(Console.ReadLine());
                    System.Console.Write("Enter First Name: ");
                    string? fname = Console.ReadLine();
                    System.Console.Write("Enter Last Name: ");
                    string? lname = Console.ReadLine();
                    System.Console.Write("Enter State: ");
                    string? state = Console.ReadLine();
                    System.Console.Write("Enter City: ");
                    string? city = Console.ReadLine();
                    System.Console.Write("Enter Department: ");
                    string? dept = Console.ReadLine();
                    var Department = new DepartmentModel()
                    {
                        Dept_Name = dept
                    };
                    var Employees = new EmployeeModel()
                    {
                        DeptId = dId,
                        First_Name = fname,
                        Last_Name = lname,
                        State = state,
                        City = city
                    };
                    DbContext.Department.Add(Department);
                    DbContext.Employee.Add(Employees);

                    DbContext.SaveChanges();
                    System.Console.WriteLine("Done...");
                    break;

                case 3:
                    System.Console.WriteLine("Program Exited...");
                    break;

                default:
                    System.Console.WriteLine("Invalid Choice...");
                    break;
            }
        }    
    }
}
