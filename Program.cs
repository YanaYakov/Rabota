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
                    int diffResult = Calculatet.GetDiff(firstNumber, secondNumber);
                    Console.WriteLine(diffResult);
                }
                if(actin == "/") 
                {
                    int divResult = Calculatet.GetDiv(firstNumber, secondNumber);
                    Console.WriteLine(divResult);
                }
            }
        }
    }
}
