using System;
using System.IO;
using System.Text;

namespace Mar_06_Task;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string FilePath = @"C:\Users\chintan.patel\Desktop\Chintan Patel\Internship\Tasks\Mar_06_Task\MyFile.txt";
            FileStream filestream_Create = new FileStream(FilePath, FileMode.Create);
            Console.WriteLine($"File has been created and the path is {FilePath}");
            filestream_Create.Close();

            FileStream filestream_Append = new FileStream(FilePath, FileMode.Append);
            byte[] bytedata = Encoding.Default.GetBytes("C# is an Object Oriented Programming Language.");
            filestream_Append.Write(bytedata, 0, bytedata.Length);
            Console.WriteLine("Successfully saved the file with data : C# is an Object Oriented Programming Language.");
            filestream_Append.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine($"Exception Caught: {e.Message}");
        }
    }
}
