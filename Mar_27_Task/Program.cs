namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using var Con = new SchoolContext();

            var Student = new Student
            {
                FirstName="Chintan",
                LastName="Patel"    
            };

            var Mark = new Mark
            {
                Science = 60,
                Maths  = 80,
                English = 70
            };

            Con.Students.Add(Student);
            Con.SaveChanges();
            // Con.Marks.Add(Mark);
            // Con.SaveChanges();
            Console.WriteLine("Data Entered!");
        }
    }
}