namespace ExampleLib
{
    public class Example
    { 
        public string type = "ex";

        public int CoolProperty { get; set; }

        public bool One(int a, string b) => false;
        public double Two(double c, double d) => c + d;
    }
}

namespace TestingNamespace
{
    public static class Wow
    {
        public static void Method(this string shit)
        {

        }
    }
}

