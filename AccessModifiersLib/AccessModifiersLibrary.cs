using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessModifiersLib
{
    public class AccessModifiersLibrary
    {
        private void Private(string s )
        {
            if (s == null || s == string.Empty)
            {
                Console.WriteLine("Private : Is only accessible in the area or scope it was declared in.");
                Console.WriteLine("In This Case since the Private is declared in the Class AccessModifiersLibrary, it can be access only within the AccessModifiersLibrary class or Scope by other methods.");
            }
            else
                Console.WriteLine(s);
        }

        public void Public(string s)
        {
            if (s == null || s == string.Empty)
                Private("Accessed By Public Method in the Scope or Class AccessModifiersLibrary.");
            else
                Console.WriteLine(s);
        }

        protected void Protected(string s)
        {
            if (s == null || s == string.Empty)
                Private("Accessed By Public Method in the Scope or Class AccessModifiersLibrary.");
            else
                Console.WriteLine(s);
        }
        internal void Internal(string s)
        {
            if (s == null || s == string.Empty)
                Console.WriteLine("Internal : Can Only Be Accessed within the Scope Or the Assembly/Project it was declared in. It Cannot be Accessed By Other Projects or Assemblies");
            else
                Console.WriteLine(s);
        }
        private protected void PrivateProtected(string s)
        {

        }

        protected internal void ProtectedInternal(string s)
        {

        }
    }
}
