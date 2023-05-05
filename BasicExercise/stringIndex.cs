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
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Apple");
            arrayList.Add("banana");
            arrayList.Add("Cherry");
            Console.WriteLine(arrayList[0]);
            Console.WriteLine(arrayList[2]);
            Console.WriteLine(arrayList[1]);
        }
    }
}
