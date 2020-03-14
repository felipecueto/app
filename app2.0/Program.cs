using System;

namespace app2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");

            persona felipe = new persona();
            felipe.correr();
            
 


       }
    }
    class persona

    {
        public string name;
        public int age;

        public  void correr()
        {
            Console.WriteLine("yo corro" );
        }
    }
}
