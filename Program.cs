using System;

namespace Class4_LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //The variable number is the input by the user.
            Console.Write("Enter a number: ");
            var userNumber = Console.ReadLine();
            //userValue is the parsed input value in variable userNumber.
            int userValue = int.Parse(userNumber);
            /*I want to assign integer sum a zero value because it will
             be used later to add the loop values together*/
            int sum = 0; 

            //Loop starts at 2 and ends at 20, as per instructions.
            for (int i = 2; i <= 20; i++)
                
            {
                /*integer multiplication takes the userValue input 
                 * and multiplies it by the loop integers (2-20).*/
                int multiplication = userValue * i;

                /*To add the output loop values together (after multipliaction)
                  sum variable is used with += operator, exceptI don't understand
                  why this is the appropriate operator. Why does += 
                  cause the compiler to add the multiplication values together??*/
                sum += multiplication;
                Console.WriteLine(multiplication);
          
            }
            //The last line printed out is the sum of the preceding loop values.
            Console.WriteLine(sum);
            Console.ReadLine();

          
        }
    }
}
