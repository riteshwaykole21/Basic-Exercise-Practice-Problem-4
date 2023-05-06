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
        public void Number() 
        {
            string Name = "C# Logic Building questions";
            char[] chars = Name.ToCharArray();   
            for(int i = Name.Length - 1 ; i >= 0; i--)
            {
               // char c = Name[i];
                Console.Write(Name[i]);
            }
            

        }
    }
}
