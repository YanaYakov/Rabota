namespace ConsoleAppYana
{
    public static class Calculatet
    {
        public static int GetSum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;

            return result;
        }

        public static int GetDiff(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;

            return result;

        }

        public static double GetDiv(int firstNumber, int secondNumber) 
        { 
            
            double result = (double)firstNumber / (double)secondNumber;

            return result;
        }

        public static int GetMultipli(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;

            return result;
        }

    }
}
