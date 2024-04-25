using Company;

namespace MVC_One_2_One;

class Program
{
    static void Main(string[] args)
    {
        AllMethod obj = new AllMethod();
        try
        {
            int choice = 0;
            while (choice != 7)
            {
                System.Console.WriteLine("|----------------------------------------|");
                System.Console.WriteLine("|           Company Database             |");
                System.Console.WriteLine("|----------------------------------------|");
                System.Console.WriteLine("| 1. For Display Employee Table          |");
                System.Console.WriteLine("| 2. For Display Address Table           |");
                System.Console.WriteLine("| 3. For Add Employee                    |");
                System.Console.WriteLine("| 4. For Add Address                     |");
                System.Console.WriteLine("| 5. For Delete Employee                 |");
                System.Console.WriteLine("| 6. For Delete Address                  |");
                System.Console.WriteLine("| 7. For Add Address with Employee       |");
                System.Console.WriteLine("| 8. For Exit                            |");
                System.Console.WriteLine("|----------------------------------------|");
                System.Console.Write("| Enter Your Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        obj.DisplayEmployee();
                        break;
                    case 2:
                        obj.DisplayAddress();
                        break;
                    case 3:
                        obj.AddEmployee();
                        break;
                    case 4:
                        obj.AddAddress();
                        break;
                    case 5:
                        obj.DeleteEmployee();
                        break;
                    case 6:
                        obj.DeleteAddress();
                        break;
                    case 7:
                        obj.AddAddressWithEmployees();
                        break;
                    case 8:
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
