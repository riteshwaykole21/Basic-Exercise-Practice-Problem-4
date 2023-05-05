using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class NumberSum
    {
        public void Number(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                     if (arr[i] >  arr[j])
                     {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;  
                     }
                }
            }
            int num = 0;
            foreach (int iteam in arr)
            {
                num++;
                if (iteam >= 0)
                {
                    break;
                }
            }
            Console.WriteLine($"The Sum Of Two Min Number is {arr[num] + arr[num - 1]}");
        }
    }
}
