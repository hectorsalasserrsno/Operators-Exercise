using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            
            int a = 17;
            int b = 4;
            int quotuent = a / b;
            int remainder = a % b;



            Console.WriteLine( a + b);
            Console.WriteLine( a - b);
            Console.WriteLine(a/b);
            Console.WriteLine(a*b);

            if(a == 17 &&  b == 4) 
            { 
                Console.WriteLine("17/4 is " + quotuent);
                Console.WriteLine("reminder " + remainder);
            }
            
            
        }
    }
}
