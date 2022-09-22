namespace Homework4Qust2;
class Program
{
    static void Main(string[] args)
    {
        int n; 
        //User inputs
        Console.WriteLine("CIDM 2315 Homework 4 question 2");
        Console.WriteLine("User will input a Value NOW !!!");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("User will pick right(1) or left(2) NOW !!!");
        string cho1 = Console.ReadLine();

        int c = 1, d =2;
                
        // if-else statement
        if(c >= d) 
        {
            // left tringle 
            for(int row = 0; row<n; row++)
            {
            for(int col = 0; col<n; col++)
                {
                if(row>=col)
                Console.Write('*');
                }
            Console.WriteLine("");
            }
        }
        else 
        {        
            //right triangle 
            int i, j, k ;  
            for (i = 1; i <= n; i++)  
            {  
            for (j = 1; j <= n-i; j++)  
                {  
               Console.Write(" ");  
                }  
            for (k = 1; k <= i; k++)  
                {  
               Console.Write("*");  
                }  
            Console.WriteLine("");  
            }  
        }
        Console.WriteLine("You Are Awesome");   
    }
}
