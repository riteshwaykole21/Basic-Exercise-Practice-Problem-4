using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class CheckPosition
    {
        public void Number()
        {
            string Name = "PHP Tutorial";
            Console.WriteLine((Name.Substring(1 ,2).Equals("HP") ? Name.Remove(1,2) : Name));
            
        }
    }
}
