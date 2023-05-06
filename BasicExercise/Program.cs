using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Check HP appears At Second Position");
            Console.WriteLine("2 :  Get A New string");
            Console.WriteLine("3 : String Index Example");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    CheckPosition checkPosition = new CheckPosition();
                    checkPosition.Number();
                    break;
                case 2:
                    NumberSum numberSum = new NumberSum();
                    int[] arr = { 19, -5, -42, 2, 77 };
                    int[] Arr1 = { 10, 34, 10, 235, 556};
                    int[] Arr2 = { 10, 12, 39, 34 };
                    numberSum.Number(arr);
                    numberSum.Number(Arr1);
                    numberSum.Number(Arr2);
                    break;
                case 3:
                    stringIndex Demo = new stringIndex();
                    Demo.Number("eDaBiTiK");
                    break;
            }
            Console.ReadLine();
        }
    }
}
