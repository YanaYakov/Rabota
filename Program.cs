namespace ConsoleAppYana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int firstNumber = Int32.Parse(Console.ReadLine());
                UserInterface.ShowActionMessege();
                string actin = Console.ReadLine();
                int secondNumber = Int32.Parse(Console.ReadLine());

                
                if(actin == "+")
                {
                    int result = Calculatet.GetSum(firstNumber, secondNumber);
                    Console.WriteLine(result);
                }
                
                if(actin == "-")
                {
                    int result = Calculatet.GetDiff(firstNumber, secondNumber);
                    Console.WriteLine(result);
                }
                
                if(actin == "/") 
                {
                    double result = Calculatet.GetDiv(firstNumber, secondNumber);
                    Console.WriteLine(result.ToString("0.000"));
                }
                
                if (actin == "*")
                {
                    int result = Calculatet.GetMultipli(firstNumber, secondNumber);
                    Console.WriteLine(result);
                }

            }
        }
    }
}
