using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
        int[] array2 = new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int[] array3 = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int Ar1 = array1.Length;
        int Ar2 = array2.Length;
        int Ar3 = array3.Length;
        Console.WriteLine("------------ TASK 1 ------------");
        for (int i = array1.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("{1}: {0}",array1[i], Ar1--);
        }
        Console.WriteLine("------------ TASK 2 ------------");
        for (int i = array2.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("{1}: {0}", array2[i], Ar2--);
        }
        Console.WriteLine("------------ TASK 3 ------------");
        for (int i = array3.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("{1}: 1 * {0} = {2}   2 * {0} = {3}   3 * {0} = {4}   4 * {0} = {5}   5 * {0} = {6}", array3[i], Ar3--, 1 * array3[i], 2 * array3[i], 3 * array3[i], 4 * array3[i], 5 * array3[i]);

        }
        Console.WriteLine("------------ TASK 4 ------------");
        Console.WriteLine("enter the password:  ");
        string password = "qwerty";
        bool unlock = false;
        do
        {
            string right = Console.ReadLine();
            if (right == password)
            {
                unlock = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorrect password!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        } while (unlock == false);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Corrent password!");

    }

}

