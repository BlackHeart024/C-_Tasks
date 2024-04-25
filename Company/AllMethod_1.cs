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
        public void AddDepartment()
        {
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("Enter new department name :- ");
            string? d_name = Console.ReadLine();
            var Department1 = new Department()
            {
                Dept_name = d_name
            };
            DbContext.Add(Department1);
            System.Console.WriteLine("Department Added");
            DbContext.SaveChanges();
            System.Console.WriteLine("Department save successfully");
            System.Console.WriteLine("-----------------------------------");
        }
        public void AddEmployee()
        {
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.WriteLine("|          Department Table         |");
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.WriteLine("| Department |");
            foreach (var D in DbContext.Department)
            {
                System.Console.WriteLine($"  For {D.Dept_name} Id is --> {D.Dept_id}");
            }
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.Write("Enter department id: ");
            int e_dep_id = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter employee name: ");
            string? e_name = Console.ReadLine();
            System.Console.Write("Enter employee address: ");
            string? e_address = Console.ReadLine();
            System.Console.Write("Enter employee salary: ");
            decimal e_salary = Convert.ToDecimal(Console.ReadLine());
            var Employee1 = new Employee()
            {
                Emp_department_id = e_dep_id,
                Emp_name = e_name,
                Emp_address = e_address,
                Emp_salary = e_salary
            };
            DbContext.Add(Employee1);
            System.Console.WriteLine("Employee Added");
            DbContext.SaveChanges();
            System.Console.WriteLine("Employee save successfully");
            System.Console.WriteLine("-----------------------------------");
        }
        public void DisplayDepartment()
        {
            System.Console.WriteLine("|-------------------------|");
            System.Console.WriteLine("|     Department Table    |");
            System.Console.WriteLine("|-------------------------|");
            System.Console.WriteLine("|     Department_name     |");
            foreach (var D in DbContext.Department)
            {
                System.Console.WriteLine($"|       {D.Dept_name}       |");
            }
            System.Console.WriteLine("|-----------------------------------|");
        }
        public void DisplayEmployee()
        {
            System.Console.WriteLine("|-------------------------------------------------------|");
            System.Console.WriteLine("|                     Employee Table                    |");
            System.Console.WriteLine("|-------------------------------------------------------|");
            System.Console.WriteLine("|  Emp_name  |  Department   | Emp_Address | Emp_salary |");
            foreach (var E in DbContext.Employee)
            {
                System.Console.WriteLine($"|  {E.Emp_name}  |   {E.Department.Dept_name}    |    {E.Emp_address}    |   {E.Emp_salary}   |");
            }
            System.Console.WriteLine("-----------------------------------");
        }
        public void UpdateDepartment()
        {
            System.Console.WriteLine("Enter Department id: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            var departmentToUpdate = DbContext.Department.FirstOrDefault(d => d.Dept_id == ID);
            if (departmentToUpdate == null)
            {
                System.Console.WriteLine("No Department id");
                return;
            }
            System.Console.WriteLine("Enter Updated Department :- ");
            departmentToUpdate.Dept_name = Console.ReadLine();
            DbContext.Update(departmentToUpdate);
            DbContext.SaveChanges();
            System.Console.WriteLine("Department updated successfully");
        }
        public void UpdateEmployee()
        {
            System.Console.WriteLine("Enter Employee id: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            var employeeToUpdate = DbContext.Employee.FirstOrDefault(d => d.Emp_id == ID);
            if (employeeToUpdate == null)
            {
                System.Console.WriteLine("No Employee id");
                return;
            }
            // System.Console.WriteLine("Enter Updated Employee name :- ");
            // employeeToUpdate.Emp_name = Console.ReadLine();
            // System.Console.WriteLine("Enter Updated Employee Address :- ");
            // employeeToUpdate.Emp_address = Console.ReadLine();
            // System.Console.WriteLine("Enter Updated Employee Salary :- ");
            // employeeToUpdate.Emp_salary = Convert.ToDecimal(Console.ReadLine());
            // System.Console.WriteLine("Enter Updated Employee Department :- ");

            System.Console.WriteLine("|-----------------------------------|");
            System.Console.WriteLine("|         Employee Update           |");
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.WriteLine("| 1. For Employee Name              |");
            System.Console.WriteLine("| 2. For Employee Address           |");
            System.Console.WriteLine("| 3. For Employee Salary            |");
            System.Console.WriteLine("| 4. For Employee Department        |");
            System.Console.WriteLine("| 5. For Exit                       |");
            System.Console.WriteLine("|-----------------------------------|");
            System.Console.Write("| Enter Your Choice : ");
            int upchoice = Convert.ToInt32(Console.ReadLine());

            switch (upchoice)
            {
                case 1:
                    System.Console.WriteLine("Enter Updated Employee name :- ");
                    employeeToUpdate.Emp_name = Console.ReadLine();
                    break;
                case 2:
                    System.Console.WriteLine("Enter Updated Employee Address :- ");
                    employeeToUpdate.Emp_address = Console.ReadLine();
                    break;
                case 3:
                    System.Console.WriteLine("Enter Updated Employee Salary :- ");
                    employeeToUpdate.Emp_salary = Convert.ToDecimal(Console.ReadLine());
                    break;
                case 4:
                    System.Console.WriteLine("Enter Updated Employee Department :- ");
                    employeeToUpdate.Department.Dept_name = Console.ReadLine();
                    break;
                case 5:
                    System.Console.WriteLine("Updated Successfully!");
                    break;
                default:
                    System.Console.WriteLine("Enter a valid choice!");
                    break;
            }
            DbContext.Update(employeeToUpdate);
            DbContext.SaveChanges();
            System.Console.WriteLine("Department updated successfully");
        }

        public void DeleteDepartment()
        {
            System.Console.WriteLine("Enter Department id: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            var departmentToDelete = DbContext.Department.FirstOrDefault(d => d.Dept_id == ID);
            if (departmentToDelete == null)
            {
                System.Console.WriteLine("No Department id");
                return;
            }
            DbContext.Remove(departmentToDelete);
            DbContext.SaveChanges();
            System.Console.WriteLine("Department deleted successfully");
        }

        public void DeleteEmployee()
        {
            System.Console.WriteLine("Enter Employee id: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            var employeeToDelete = DbContext.Employee.FirstOrDefault(e => e.Emp_id == ID);
            if (employeeToDelete == null)
            {
                System.Console.WriteLine("No Employee id");
                return;
            }
            DbContext.Remove(employeeToDelete);
            DbContext.SaveChanges();
            System.Console.WriteLine("Employee deleted successfully");
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
            if(responce == 'Y')
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
                DbContext.Add(Department1);
                System.Console.WriteLine("Department Added");
                DbContext.Add(Employee1);
                System.Console.WriteLine("Employee Added");
            }
            DbContext.SaveChanges();
            System.Console.WriteLine("Department save successfully");
            System.Console.WriteLine("-----------------------------------");
        }
    }
}