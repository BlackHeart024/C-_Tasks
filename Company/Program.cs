using System.Threading.Tasks.Dataflow;

namespace Company;
class Program
{
    static void Main(string[] args)
    {
        AllMethod obj = new AllMethod();
        try
        {
            int choice = 0;
            while (choice != 10)
            {
                System.Console.WriteLine("|---------------------------------------|");
                System.Console.WriteLine("|         Company Database              |");
                System.Console.WriteLine("|---------------------------------------|");
                System.Console.WriteLine("| 1. For Display Employee Table         |");
                System.Console.WriteLine("| 2. For Display Department Table       |");
                System.Console.WriteLine("| 3. For Add Employee                   |");
                System.Console.WriteLine("| 4. For Add Department                 |");
                System.Console.WriteLine("| 4. For Add Department with Employees  |");
                System.Console.WriteLine("| 5. For Update Employee                |");
                System.Console.WriteLine("| 6. For Update Department              |");
                System.Console.WriteLine("| 7. For Delete Employee                |");
                System.Console.WriteLine("| 8. For Delete Department              |");
                System.Console.WriteLine("| 9. For Exit                           |");
                System.Console.WriteLine("|---------------------------------------|");
                System.Console.Write("| Enter Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        obj.DisplayEmployee();
                        break;
                    case 2:
                        obj.DisplayDepartment();
                        break;
                    case 3:
                        obj.AddEmployee();
                        break;
                    case 4:
                        obj.AddDepartment();
                        break;
                    case 5:
                        obj.AddDepartmentWithEmployees();
                        break;
                    case 6:
                        obj.UpdateEmployee();
                        break;
                    case 7:
                        obj.UpdateDepartment();
                        break;
                    case 8:
                        obj.DeleteEmployee();
                        break;
                    case 9:
                        obj.DeleteDepartment();
                        break;
                    case 10:
                        System.Console.WriteLine("Thanks for visiting!");
                        break;
                    default:
                        System.Console.WriteLine("Please Enter a valid choice!");
                        break;
                }
            }
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine($"Error : {ex.Message}");
            System.Console.WriteLine($"Inner Ex :  {ex.InnerException}");
        }
    }
}