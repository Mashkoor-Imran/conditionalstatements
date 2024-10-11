public class ConditionalStatements
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Please Enter Your Marks");
        int m=Convert.ToInt32(Console.ReadLine());
        if (m >= 33)
            {
            Console.WriteLine("Your are Pass");
            Console.ReadLine();

        }
        else
        {
            Console.WriteLine("Your are fail");
            Console.ReadLine();
        }

    }
}