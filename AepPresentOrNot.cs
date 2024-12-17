using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BasicPrograms2
{
    internal class AepPresentOrNot
    {
        public static void Main(string[] args)
        {
            Console.WriteLine( "enter the string");
            string st = Console.ReadLine();
            Check(st);
        }
       
        public static void Check(string st)
        {
            int acount = 0;
            int ecount = 0;
            int pcount = 0;
            char[] chars = st.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a')

                    acount++;
                else if (chars[i] == 'e')
                    ecount++;
                else if (chars[i] == 'p')
                    pcount++;






            }
            
            
            if (acount != 0 && ecount != 0 && pcount != 0)
                Console.WriteLine("all present");

            else if (ecount != 0 || pcount != 0 || acount != 0)
                Console.WriteLine("one of them is present");

            else
                Console.WriteLine("none is present");



        }
       

       
        
    }
}
