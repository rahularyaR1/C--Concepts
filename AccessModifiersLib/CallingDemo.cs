using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessModifiersLib
{
    public class CallingDemo
    {
        public void MakeDemoCalls()
        {
            Console.WriteLine("This is A Method In Calling Demo Class or In the Same Project.");
            AccessModifiersLibrary am = new();
            am.Public("Accessed Public Method From AccessModifiersLibrary i.e. within the same Assembly or Project");
            am.Internal("");
        }
    }
}