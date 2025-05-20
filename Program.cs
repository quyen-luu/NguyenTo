public class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Cac so nguyen to nho hon 100: ");

        for (int i = 2; i <= 100; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    

}