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
            string Duplicate = "";
            string Name = "Ritesh Nivrutti Waykole";
            char[] Chars = Name.ToCharArray();
            char c;
            int num = 0;
            for (int i = 0; i < Chars.Length; i++)
            {
                for (int j = i + 1; j < Chars.Length; j++)
                {
                    if (Chars[i] == Chars[j])
                    {
                        if (!Duplicate.Contains(Name[i].ToString()))
                        {
                            Duplicate += Name[i];
                        }
                    }
                }
            }
            Console.WriteLine(Duplicate);

        }
    }
}
