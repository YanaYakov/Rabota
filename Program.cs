namespace ConsoleAppYana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                double firstNumber =    Double.Parse(Console.ReadLine());
                UserInterface.ShowActionMessege();
                string actin = Console.ReadLine();
                double secondNumber = Double.Parse(Console.ReadLine());
                double result = 0;
                
                if(actin == "+")
                {
                    result = Calculatet.GetSum(firstNumber, secondNumber);
                }
                
                if(actin == "-")
                {
                    result = Calculatet.GetDiff(firstNumber, secondNumber);
                }
                
                if(actin == "/") 
                {
                    result = Calculatet.GetDiv(firstNumber, secondNumber);
                }
                
                if (actin == "*")
                {
                    result = Calculatet.GetMultipli(firstNumber, secondNumber);
                }

                Console.WriteLine(result);
            }
        }
    }
}
