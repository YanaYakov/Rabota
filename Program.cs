namespace ConsoleAppYana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
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
                Console.WriteLine("Exit the program? Press 1 for exit, 2 for repeat calculate");
                answer = Console.ReadLine();

            }
            while (answer != "1") ;
        }
    }
}
