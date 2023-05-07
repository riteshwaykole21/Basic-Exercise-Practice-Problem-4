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
            int[] Number = { 10, 20, 30, 40, 50 };
            int Sum = 0;
            for(int i = 0; i < Number.Length;i++)
            {
                Sum += Number[i];                
            }
            Console.WriteLine(Sum);
        }
    }
}
