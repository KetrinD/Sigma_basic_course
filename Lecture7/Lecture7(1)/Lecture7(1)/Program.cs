using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture7_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input file operation create/delete/copy <file path>");
            var text = Console.ReadLine();

            var commandArray = text.Trim().Split(' ');
            var command = commandArray[0];
            var filePath = commandArray[1];
            var fileName = Path.GetFileName(filePath);

            if (filePath.Length > 256)
            {
                Console.WriteLine("File path is too long and more than 256 characters");
                Console.ReadKey();
            }

            

            switch (command)
            {
                case "create":

                    if (!File.Exists(filePath))
                    {
                        CreateNewFile(filePath, "The Way I Do");
                        Console.WriteLine("File was successfully created");
                    }
                    else
                    {
                        Console.WriteLine("Do you want to overwrite? y/n");
                        if (Console.ReadLine().ToLower().Equals("y") ? true : false)
                        {
                            Console.WriteLine("What do you want to write?");
                            var text_2 = Console.ReadLine();
                            CreateNewFile(filePath, text_2);
                            Console.WriteLine("File was successfully overwrited");
                        }
                        else
                        {
                            Console.WriteLine("File was not overwrited");
                            Console.ReadKey();
                        }
                    }
                    break;

                case "delete":
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        Console.WriteLine("File was successfully deleted");
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                    break;

                case "copy":
                    if (File.Exists(filePath))
                    {
                        Console.WriteLine("Please enter a target Path for new file: ");
                        var targetPath = Console.ReadLine();
                        string destFile = Path.Combine(targetPath, fileName);      
                        if (filePath != destFile)
                        {
                            Directory.CreateDirectory(targetPath);
                            File.Copy(filePath, destFile, true);
                            Console.WriteLine("File was successfully copied");
                        }
                        else
                        {
                            Console.WriteLine("You entered previous file Path, overwriting is not allowed");
                        }

                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                    break;
            }    
            Console.ReadKey();
        }
        
        static void CreateNewFile(string filePath, string content)
        {
            using (StreamWriter stream = new StreamWriter(filePath, false))
                stream.WriteLine(content);
        }

    }
}
