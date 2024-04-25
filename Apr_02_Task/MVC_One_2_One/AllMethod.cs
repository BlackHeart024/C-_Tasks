using Microsoft.EntityFrameworkCore;

namespace Company
{
    public class AllMethod
    {
        private readonly CompDbContext DbContext;
        public AllMethod()
        {
            DbContext = new CompDbContext();
        }
        public void AddAddress()
        {
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("Enter new Address :- ");
            string? address = Console.ReadLine();
            var Address1 = new AddressMaster()
            {
                Address = address
            };
            DbContext.Add(Address1);
            System.Console.WriteLine("Address Added");
            DbContext.SaveChanges();
            System.Console.WriteLine("Address save successfully");
            System.Console.WriteLine("-----------------------------------");
        }
        public void AddEmployee()
        {
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.WriteLine("|          Address Table         |");
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.WriteLine("| Address |");
            foreach (var A in DbContext.AddressMaster)
            {
                System.Console.WriteLine($"  For {A.Address} Id is --> {A.Address_id}");
            }
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.Write("Enter Address id: ");
            int e_add_id = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter employee name: ");
            string? e_name = Console.ReadLine();
            var Employee1 = new EmployeeMaster()
            {
                Employee_address_id = e_add_id,
                Employee_name = e_name
            };
            DbContext.Add(Employee1);
            System.Console.WriteLine("Employee Added");
            DbContext.SaveChanges();
            System.Console.WriteLine("Employee save successfully");
            System.Console.WriteLine("-----------------------------------");
        }
        public void DisplayAddress()
        {
            System.Console.WriteLine("|-------------------------|");
            System.Console.WriteLine("|       Address Table     |");
            System.Console.WriteLine("|-------------------------|");
            System.Console.WriteLine("|         Address         |");
            foreach (var A in DbContext.AddressMaster)
            {
                System.Console.WriteLine($"|       {A.Address}       |");
            }
            System.Console.WriteLine("|-----------------------------------|");
        }
        public void DisplayEmployee()
        {
            System.Console.WriteLine("|------------------------------------|");
            System.Console.WriteLine("|           Employee Table           |");
            System.Console.WriteLine("|    Emp_name    |    Emp_Address    |");
            System.Console.WriteLine("|------------------------------------|");
            foreach (var E in DbContext.EmployeeMaster)
            {
                System.Console.WriteLine($"|  {E.Employee_name}  |    {E.AddressMaster.Address}    |");
            }
            System.Console.WriteLine("-----------------------------------");
        }
        public void DeleteEmployee()
        {
            System.Console.WriteLine("Enter Employee id: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            var employeeToDelete = DbContext.EmployeeMaster.FirstOrDefault(e => e.Employee_id == ID);
            if (employeeToDelete == null)
            {
                System.Console.WriteLine("No Employee id");
                return;
            }
            DbContext.Remove(employeeToDelete);
            DbContext.SaveChanges();
            System.Console.WriteLine("Employee deleted successfully");
        }
        public void DeleteAddress()
        {
            System.Console.WriteLine("Enter Address id: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            var addressToDelete = DbContext.AddressMaster.FirstOrDefault(e => e.Address_id == ID);
            if (addressToDelete == null)
            {
                System.Console.WriteLine("No Address id");
                return;
            }
            DbContext.Remove(addressToDelete);
            DbContext.SaveChanges();
            System.Console.WriteLine("Address deleted successfully");
        }

        public void AddAddressWithEmployees()
        {
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("Enter new Address:- ");
            string? address = Console.ReadLine();
            var Address1 = new AddressMaster()
            {
                Address = address
            };
            DbContext.Add(Address1);
            DbContext.SaveChanges();
            System.Console.Write("Do you want to add Employees to this Address? (Y/N): ");
            char? response = Convert.ToChar(Console.ReadLine());
            if (response == 'Y')
            {
                    System.Console.Write("Enter employee name: ");
                    string? e_name = Console.ReadLine();
                    var Employee1 = new EmployeeMaster()
                    {
                        Employee_address_id = Address1.Address_id,
                        Employee_name = e_name,
                    };
                    DbContext.Add(Employee1);
                    System.Console.WriteLine("Employee Added");
                    DbContext.SaveChanges();
                System.Console.WriteLine($"Address Added with Employee");
            }
            else if (response == 'N')
            {
                DbContext.Add(Address1);
                DbContext.SaveChanges();
                System.Console.WriteLine("Address save successfully");
                System.Console.WriteLine("-----------------------------------");
                return;
            }
        }
    }
}