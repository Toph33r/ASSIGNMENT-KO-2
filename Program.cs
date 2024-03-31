namespace ASSIGNMENT_KO_2
{
    internal class Program
    {//Lauron, Clarence Christopher L.
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                if (num % 15 == 0)
                {
                    Console.WriteLine("Hello,Goodbye!");
                }
                else if (num % 3 == 0) {
                    Console.WriteLine("Hello!");
                 
                }else if (num % 5 == 0) { Console.WriteLine("Goodbye!"); }
                else { Console.WriteLine(num); }
            }   
        }
    }
}
