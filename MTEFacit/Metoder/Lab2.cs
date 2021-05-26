using System.Diagnostics.CodeAnalysis;

namespace MTEFacit.Metoder
{
    public class Lab2
    {
        public string PlussaStringar(string a, string b)
        {
            return a + b;
        }


        public void Run()
        {
            string s1 = "Hello ";
            string s2 = "World ";

            string result = PlussaStringar(s1,s2);
            //string result = s1 + s2;
        }
    }
}