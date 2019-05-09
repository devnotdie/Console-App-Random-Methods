using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleAppRandomMethods
{
    class Password
    {

        private static Random random = new Random();
        static public int QuantityPasswords { get; set; }
       static public int QuantityCharInPassword { get; set; }
        static private string[] ArrayPasswords;

      
        


        static public string[] PasswordsGenerator
        {
            get { return ArrayPasswords; }
        }

      

        static public void PasswordGenerator()
        {
            
            ArrayPasswords = new string[QuantityPasswords];
            string str = null;
            for (int i = 0; i < ArrayPasswords.Length; i++)
            {
                str = RandomString(QuantityCharInPassword);


                    if (RegexWorldCheck(str)  && DuplicateСheck.CheckWordInArrayForDuplicate(ArrayPasswords, str))
                    {
                        ArrayPasswords[i] = str;
                    }
                    else
                    {
                        i--;
                    }
                
               

            }




        }//PasswordGenerator()


     


        static private string RandomString(int length)
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static private bool RegexWorldCheck(string str)
        {

            Regex regex;
            string patternOfWorlds = "(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])[A-Za-z0-9]+";
            regex = new Regex(patternOfWorlds);

            if (regex.IsMatch(str))
            {
                return true;
            }

            return false;
        }



        static public void Show()
        {
            foreach (var item in PasswordsGenerator)
            {
                Console.WriteLine(item );
            }
        }

    }
}
