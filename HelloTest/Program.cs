using System;
using System.Diagnostics;




namespace HelloTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the path to the file
            Console.WriteLine("Enter the path to the jar file: ");
            string filePath = Console.ReadLine();

            Console.WriteLine("Enter the source XML: ");
            string sourcePath = Console.ReadLine();
            // Construct the command to execute
            string command = "java -jar \"" + filePath +"\" \"" + sourcePath + "\"";
            Debug.WriteLine(command);
            // Start a new process to run the command
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c " + command);
            Process p = Process.Start(psi);

            // Wait for the process to exit
            p.WaitForExit();

            // Display the process exit code
            Console.WriteLine("Exit code: " + p.ExitCode);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
