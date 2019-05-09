using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRandomMethods
{
    class DateOld
    {
       static Random random = new Random();
        static public int FromNumber { get; set; }
        static public int ToNumber { get; set; }
        static public int QuantityDate { get; set; }

      // static private DateTime randomBirthday;

        static public string[] GeneratorDateNew
        {
            get
            {
                return arrayDate;
            }
        }
        static string[] arrayDate;

      
     
        static public void GeneratorDate()
        {
            arrayDate = new string[QuantityDate];
      
            for (int i = 0; i < arrayDate.Length; i++)
            {

                arrayDate[i] = AgeGeneration();
              

            }

          
          

        }
        static private string AgeGeneration()
        {


          
            do
            {
               int year = random.Next(DateTime.Now.Year-100, DateTime.Now.Year);
                int month = random.Next(1,12);
                int day = random.Next(1,DateTime.DaysInMonth(year, month));
               var randomBirthday = new DateTime(year, month, day);

              int  age = new DateTime((DateTime.Now - randomBirthday).Ticks).Year - 1;
                if (age > FromNumber && age < ToNumber)
                {
                    return randomBirthday.ToString("dd.MM.yyyy");
                    
                }

            } while (true);

           

        }



    }
}
