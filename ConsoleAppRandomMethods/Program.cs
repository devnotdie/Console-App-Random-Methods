using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;


namespace ConsoleAppRandomMethods
{
    class Program
    {
        static void StartApp()
        {
           
            while (true)
            {
                Console.Title = "Программа генерации паролей и даты";

           
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Выберите цифру.");
            Console.WriteLine("1-Генерация имен");
            Console.WriteLine("2-Генерация паролей");
            Console.WriteLine("3-Генерация даты");
          
            Console.WriteLine("4-Выйти");
            Console.WriteLine(new string('-', 30));
            int switchOn = Convert.ToInt32(Console.ReadLine());

            
              

         
                switch (switchOn)
                {
                    case 1:
                        LaunchModule.GeneratorOfFullNameWriteToFile();
                        break;
                    case 2:
                        LaunchModule.GeneratorPasswordsWriteToFile();
                        break;
                    case 3:
                        LaunchModule.GeneratorDateWriteToFile();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Попробуйте еще раз");
                        break;

                }
                Console.Clear();
            }
            
        }

     


        static void Main(string[] args)
        {
            StartApp();


          
            

            
            Console.ReadKey();

        }
    }
}
