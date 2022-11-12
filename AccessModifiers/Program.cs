using AccessModifiersLib;
using System.Linq;

namespace Program 
{
    public class AccessModifiers
    {
        public static void Main(string[] args)
        {
            string am = "Public, Private, Protected, Private Protected, Protected Internal, Internal";
            Console.WriteLine($"Access Modifiers in C# specifies who can see and use the resources.\nThere are 6 different types of Access Modifiers : {am}.");
            AccessModifiersLibrary aml = new();
            aml.Public("");
            CallingDemo callingDemo = new();
            callingDemo.MakeDemoCalls();
        }
    }
}