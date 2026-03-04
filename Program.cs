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
                
                else if(actin == "-")
                {
                    result = Calculatet.GetDiff(firstNumber, secondNumber);
                }

                else if (actin == "/") 
                {
                    result = Calculatet.GetDiv(firstNumber, secondNumber);
                }

                else if (actin == "*")
                {
                    result = Calculatet.GetMultipli(firstNumber, secondNumber);
                }

                else
                {
                    Console.WriteLine("Please enter valid action");
                }

                Console.WriteLine(result);
            }
        }
    }
}
