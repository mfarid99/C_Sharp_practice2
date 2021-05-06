using System;

namespace HelloWorld2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 5;
            var b = 9;
            var c = a + b;
            string str = "1234";
            int num = Convert.ToInt32(str);

            int e = 7;
            int f = e++;
            int g = ++e;
            Console.WriteLine(f);
            Console.WriteLine(e);
            Console.WriteLine(g);


            Console.WriteLine(c);
            Console.WriteLine("Hello nass");
            Console.WriteLine(num);
        }
    }
}
