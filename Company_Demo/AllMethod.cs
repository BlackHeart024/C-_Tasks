using Microsoft.EntityFrameworkCore;

namespace Company_Demo
{
    public class AllMethod
    {
        private readonly CompDbContext DbContext;
        public AllMethod()
        {
            DbContext = new CompDbContext();
        }
        public void InsertEmp()
        {
            System.Console.WriteLine("Enter Employee name: ");
            string name = Console.ReadLine();

            var emp = new Employee()
            {
                Emp_name = name
            };

            System.Console.WriteLine("Employee Added");
        }

        public void EmpDisplay()
        {
            System.Console.WriteLine("      Employee Id            Employee Name        ");
            foreach (var emp in DbContext.Employee)
            {
                System.Console.WriteLine($"      {emp.Emp_id}          {emp.Emp_name}");
            }
        }

        public void UpdateEmp()
        {
            System.Console.WriteLine("Enter Employee Id: ");
            int empid = Convert.ToInt32(Console.ReadLine());

            var Emp2Update = DbContext.Employee.FirstOrDefault(e => e.Emp_id == empid);

            if (Emp2Update == null)
            {
                System.Console.WriteLine("Employee does not exist");
                return;
            }

            System.Console.WriteLine("Enter new Employee name: ");
            Emp2Update.Emp_name = Console.ReadLine();
            DbContext.Update(Emp2Update);
            DbContext.SaveChanges();
        }

        public void DeleteEmp()
        {
            System.Console.WriteLine("Enter Employee Id: ");
            int empid = Convert.ToInt32(Console.ReadLine());

            var Emp2Remove = DbContext.Employee.FirstOrDefault(e => e.Emp_id == empid);

            if (Emp2Remove == null)
            {
                System.Console.WriteLine("Employee does not exist");
                return;
            }
            DbContext.Remove(Emp2Remove);
            DbContext.SaveChanges();
        }

        public void AddDepartmentWithEmployees()
        {
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("Enter new department name :- ");
            string? d_name = Console.ReadLine();
            var Department1 = new Department()
            {
                Dept_name = d_name
            };
            System.Console.Write("Do you want to add Employees to this Department? (Y/N): ");
            char? responce = Convert.ToChar(Console.ReadLine());


            if (responce == 'Y')
            {
                System.Console.WriteLine("How many employees you want to add: ");
                int totemp = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < totemp; i++)
                {
                    System.Console.Write("Enter employee name: ");
                    string? e_name = Console.ReadLine();
                    System.Console.Write("Enter employee address: ");
                    string? e_address = Console.ReadLine();
                    System.Console.Write("Enter employee salary: ");
                    decimal e_salary = Convert.ToDecimal(Console.ReadLine());
                    var Employee1 = new Employee()
                    {
                        Emp_department_id = Department1.Dept_id,
                        Emp_name = e_name,
                        Emp_address = e_address,
                        Emp_salary = e_salary
                    };
                    DbContext.Add(Employee1);
                    System.Console.WriteLine("Employee Added");
                    DbContext.SaveChanges();
                }
            }
            DbContext.Add(Department1);
            DbContext.SaveChanges();

            System.Console.WriteLine("Department Added");
            System.Console.WriteLine("Department save successfully");
            System.Console.WriteLine("-----------------------------------");
        }
    }
}