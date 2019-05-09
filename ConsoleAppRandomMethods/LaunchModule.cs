using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRandomMethods
{
    class LaunchModule
    {


        static public void GeneratorPasswordsWriteToFile()
        {
            string path = "Password.txt";
            Console.Clear();
            Console.WriteLine(new string('-',30));
            Console.WriteLine("Создание пароля");
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите число сгенерируемых паролей:");
            Password.QuantityPasswords= Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nВведите длинну пароля: ");
            Password.QuantityCharInPassword = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 30));

           Password.PasswordGenerator();
            CreateFile.WriteToFile(path, Password.PasswordsGenerator);

        }

        static public void GeneratorDateWriteToFile()
        {
            string path = "Date.txt";
            Console.Clear();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Создание даты");
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите нужное количество даты:");
            DateOld.QuantityDate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите возраст (Пример: от 18 до 20");
            Console.WriteLine("От:");
            DateOld.FromNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("До:");
            DateOld.ToNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 30));

            DateOld.GeneratorDate();
            CreateFile.WriteToFile(path, DateOld.GeneratorDateNew);

        }

        static public void GeneratorOfFullNameWriteToFile()
        {
            RandomOfFullName randomOfFullName = new RandomOfFullName();

            string path = "FullName.txt";
            Console.Clear();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Генерация имен");
            Console.WriteLine(new string('-', 30));
            while (true)
            {
                Console.WriteLine("1 - М");
            Console.WriteLine("2 - Ж");


                int sex = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(new string('-', 30));
           
                switch (sex)
                {
                    case 1:
                       
                        Console.WriteLine("Введите число сгенерируемых имен:");
                        randomOfFullName.QuantityOfFullName = Convert.ToInt32(Console.ReadLine());
                        randomOfFullName.RandomFullNameOfMan();
                        CreateFile.WriteToFile(path, randomOfFullName.FullName);
                        break;
                    case 2:
                     
                        Console.WriteLine("Введите число сгенерируемых имен:");
                        randomOfFullName.QuantityOfFullName = Convert.ToInt32(Console.ReadLine());
                        randomOfFullName.RandomFullNameOfWoman();
                        CreateFile.WriteToFile(path, randomOfFullName.FullName);
                        break;

                    default:
                        Console.WriteLine("Неправильный ввод!");
                        Console.WriteLine(new string('-', 30));
                        break;
                }




            }


         


         

            
           

        }
    }
}
