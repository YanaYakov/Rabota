namespace ConsoleAppYana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                UserInterface.ShowActionMessege();
                string expression = Console.ReadLine().Trim();
                
                int index = expression.IndexOfAny(new char[] { '+', '-', '/', '*' });
                char actin = expression[index];

                string[] numers = expression.Split(actin);

                double firstNumber = Double.Parse(numers[0].Trim());
                double secondNumber = Double.Parse(numers[1].Trim());
                double result = 0;
                
                
                switch (actin)
                {
                    case '+':
                    result = Calculatet.GetSum(firstNumber, secondNumber);
                        break;

                    case '-':
                    result = Calculatet.GetDiff(firstNumber, secondNumber);
                        break;

                    case '/': 
                    result = Calculatet.GetDiv(firstNumber, secondNumber);
                        break;

                    case '*':
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
