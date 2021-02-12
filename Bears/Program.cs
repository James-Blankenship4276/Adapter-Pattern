using System;

namespace Bears
{
    class Program
    {
        static void Main(string[] args)//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/explicit-interface-implementation
        {
            Grizzly grizzly = new Grizzly();
            TeddyBear teddyBear = new TeddyBear();
            Bear bear = grizzly;
            ToyBear toy = teddyBear;
            BearAdapter adapter = new BearAdapter(bear);
            bear.maul();
            bear.hibernate();
            toy.hug();
            toy = adapter;
            toy.hug();
                
            
            
        }
    }
}
