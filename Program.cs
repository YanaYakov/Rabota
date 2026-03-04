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
                
                
                switch (actin)
                {
                    case "+":
                    result = Calculatet.GetSum(firstNumber, secondNumber);
                        break;

                    case "-":
                    result = Calculatet.GetDiff(firstNumber, secondNumber);
                        break;

                    case "/": 
                    result = Calculatet.GetDiv(firstNumber, secondNumber);
                        break;

                    case "*":
                    result = Calculatet.GetMultipli(firstNumber, secondNumber);
                        break;

                    default:
                        Console.WriteLine("Try again. Non correct actin");
                        break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
