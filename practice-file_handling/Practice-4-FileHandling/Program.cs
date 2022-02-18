using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice_4_FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\";
            string fol, directory;

            Console.Write("Enter Folder Name: ");
            fol = Console.ReadLine();

            directory = Path.Combine(path, fol);

            DirectoryInfo create = new DirectoryInfo(directory);
            try
            {
                if (create.Exists)
                {
                    Console.WriteLine("{0} Folder is already exists!", directory);
                    Console.WriteLine("Folder Name: {0}", create.Name);
                    Console.WriteLine("Folder Path: {0}", create.FullName);
                    Console.WriteLine("Folder is created on: {0}", create.CreationTime);
                    Console.WriteLine("Folder is last accessed on: {0}", create.LastAccessTime);
                    Console.WriteLine("\n");
                }
                else
                {
                    create.Create();
                    Console.WriteLine(directory + " Folder is created Successfully!");
                    Console.WriteLine("Folder Name: {0}", create.Name);
                    Console.WriteLine("Folder Path: {0}", create.FullName);
                    Console.WriteLine("Folder is created on: {0}", create.CreationTime);
                    Console.WriteLine("Folder is last accessed on: {0}", create.LastAccessTime);
                    Console.WriteLine("\n");
                }
            }
            catch
            {

            }

            string fpath, fdirectory, file;

            Console.Write("Enter File Name: ");
            fpath = Console.ReadLine();
            file = fpath + ".txt";

            fdirectory = Path.Combine(directory, file);

            FileInfo f = new FileInfo(fdirectory);

            try
            {
                if (f.Exists)
                {
                    Console.WriteLine("{0} Directory is already exists!", fdirectory);
                    Console.WriteLine("File Name: {0}", f.Name);
                    Console.WriteLine("File Path: {0}", f.FullName);
                    Console.WriteLine("File is created on: {0}", f.CreationTime);
                    Console.WriteLine("File is last accessed on: {0}", f.LastAccessTime);
                    Console.WriteLine("\n");
                }
                else
                {
                    f.CreateText();
                    Console.WriteLine(fdirectory + " File is created Successfully!");
                    Console.WriteLine("File Name: {0}", f.Name);
                    Console.WriteLine("File Path: {0}", f.FullName);
                    Console.WriteLine("File is created on: {0}", f.CreationTime);
                    Console.WriteLine("File is last accessed on: {0}", f.LastAccessTime);
                    Console.WriteLine("\n");
                }
            }
            catch
            {

            }

            string name, country, subject;
            int age;

            using (StreamWriter write = new StreamWriter(fdirectory, append: true))
            {
                Console.WriteLine("Please Enter your Details.");

                Console.Write("Your Name: ");
                name = Console.ReadLine();
                Console.Write("Your Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Your Current Country: ");
                country = Console.ReadLine();
                Console.Write("Your Subject: ");
                subject = Console.ReadLine();

                write.WriteLine("Name: {0}", name);
                write.WriteLine("Age: {0}", age);
                write.WriteLine("Country: {0}", country);
                write.WriteLine("Subject: {0}", subject);
                Console.WriteLine();
            }



            Console.WriteLine("Information Saved on {0}\n", fdirectory);

            int x;

            Console.WriteLine("Press 1 to view Saved File");
            Console.WriteLine("Press 2 to view Directory Info");
            Console.WriteLine("Press any key to Exit.");

            x = Convert.ToInt32(Console.ReadLine());

            StreamReader read = new StreamReader(fdirectory);
            

            switch (x)
            {
                case 1:
                    Console.WriteLine(read.ReadToEnd());
                    break;

                case 2:
                    Console.WriteLine("\nFolder Name: {0}", create.Name);
                    Console.WriteLine("Folder Path: {0}", create.FullName);
                    Console.WriteLine("Folder is created on: {0}", create.CreationTime);
                    Console.WriteLine("Folder is last accessed on: {0}", create.LastAccessTime);
                    Console.WriteLine("\n");
                    break;

                default:

                    break;
            }
            


            Console.ReadKey();

        }

    }
}
