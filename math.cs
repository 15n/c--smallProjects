class Program
    {
        static void Main(string[] args)
        {
            int baseNumber, expNumber, result = 1;
            Console.Write("Base Number : ");
            baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("exponent Number : ");
            expNumber = Convert.ToInt32(Console.ReadLine());
 
 
            while (expNumber != 0)
            {
                result *= baseNumber;
                --expNumber;
            }
 
            Console.WriteLine("Result = {0}", result);
 
            Console.ReadLine();
        }
    }
 
