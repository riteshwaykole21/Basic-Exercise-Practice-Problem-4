using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class stringIndex
    {
        public void Number(string str) 
        {
             int middel = str.Length / 2;
             if (str.Length % 2 == 0)
             {
                  Console.WriteLine(str.Substring(middel - 1 ,2));
             }
             else
             {
                Console.WriteLine(str.Substring(middel , 1));
             }
        }
    }
}
