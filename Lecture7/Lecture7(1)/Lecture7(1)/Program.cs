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
            var fileDirectory = filePath.Replace("\\test.txt.", "");
            var fileName = Path.GetFileName(filePath);

            switch (command)
            {
                case "create":
                    if ((!Directory.Exists(fileDirectory)) && (!File.Exists(filePath)))
                    {
                        if (filePath.Length < 256)
                        {
                            Console.WriteLine("This Directory does not exist. It will be created for you ");
                            Directory.CreateDirectory(fileDirectory);
                            Console.WriteLine($"Directory {fileDirectory} was successfully created ");

                            CreateFile(filePath, "The Way I Do");
                            Console.WriteLine($"File was successfully created in Directory {filePath}");
                        }
                        else
                        {
                            Console.WriteLine("File path is too long and more than 256 characters");
                        }
                    }
                    else if ((Directory.Exists(fileDirectory)) && (!File.Exists(filePath)))
                    {
                        CreateFile(filePath, "The Way I Do");
                        Console.WriteLine($"File was successfully created in Directory {filePath}");
                    }

                    else if ((Directory.Exists(fileDirectory)) && (File.Exists(filePath)))
                    {
                            Console.WriteLine("Do you want to overwrite this file? y/n");
                            if (Console.ReadLine().ToLower().Equals("y") ? true : false)
                            {
                                Console.WriteLine("What do you want to write there?");
                                var text_2 = Console.ReadLine();
                                CreateFile(filePath, text_2);
                                Console.WriteLine("File was successfully overwrited");
                            }
                            else
                            {
                                Console.WriteLine("You said 'No'. File was not overwrited");
                            }
                    }
                    break;

                case "delete":
                    if ((Directory.Exists(fileDirectory)) && (File.Exists(filePath)))
                    {
                        File.Delete(filePath);
                        Console.WriteLine("File was successfully deleted");
                    }
                    else
                    {
                        if (!Directory.Exists(fileDirectory))
                        {
                            Console.WriteLine("Directory does not exist");
                        }
                        else if (!File.Exists(filePath))
                        {
                            Console.WriteLine("File does not exist in this Directory");
                        }

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

        static void CreateFile(string filePath, string content)
        {
            using (StreamWriter stream = new StreamWriter(filePath, false))
                stream.WriteLine(content);
        }

    }
}


