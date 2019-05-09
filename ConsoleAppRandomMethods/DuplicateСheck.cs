using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRandomMethods
{
    class DuplicateСheck
    {


        static public bool CheckWordInArrayForDuplicate(string[] arrayCheck, string word)
        {

            for (int i = 0; i < arrayCheck.Length; i++)
            {

                if (arrayCheck[i] == word)
                {
                    return false;
                }

                
            }

            return true;


        }


    }
}
