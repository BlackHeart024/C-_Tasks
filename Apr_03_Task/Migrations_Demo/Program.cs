namespace Migrations_Demo;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 3)
        {
            System.Console.WriteLine("|-------------------------------------|");
            System.Console.WriteLine("|           Student Database          |");
            System.Console.WriteLine("|-------------------------------------|");
            System.Console.WriteLine("| 1. Add Student                      |");
            System.Console.WriteLine("| 2. Display Student                  |");
            System.Console.WriteLine("| 3. Exit                             |");
            System.Console.WriteLine("|-------------------------------------|");
            System.Console.WriteLine("| Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
    }
}
