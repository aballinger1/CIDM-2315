namespace Homework4Qust1;
class Program
{
    static void Main(string[] args)
    {
            int a;
            int b;
            int max;

            //input numbers
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            //finding max number
            if (a > b)
                max = a;
            else
                max = b;
           
            //finding max number
            max = (a > b) ? a : b;

            //printing
            Console.WriteLine("A = {0}",a);
            Console.WriteLine("B = {0}",b);
            Console.WriteLine("Maximum number = {0}", max);

           
    }
}
