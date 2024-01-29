using System.Collections;
using System.Security.Cryptography.X509Certificates;
using static Collections.Supplier;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var supplier = new Supplier();

            supplier.Talk( x => Console.WriteLine(x.ToUpper()) );

            Console.ReadLine();
        }

        static void Escritor(string text)
        {
            Console.WriteLine($"FROM ESCRITOR: {text}");
        }
    }
}
