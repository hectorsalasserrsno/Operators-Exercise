using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
           
        static void Main(string[] args)
        {
            
            
            
            int a = 17;  //excercise 1
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


            
            
            Console.WriteLine("What is the radius of your circle?");
            double input = double.Parse(Console.ReadLine());
            var answer = Math.PI * Math.Pow(input, 2);
            Console.WriteLine(answer);
            
            

        }
        
        
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.PI * radius * radius;
  
        }

    }
}
