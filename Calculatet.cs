namespace ConsoleAppYana
{
    public static class Calculatet
    {
        public static double GetSum(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;

            return result;
        }

        public static double GetDiff(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;

            return result;

        }

        public static double GetDiv(double firstNumber, double secondNumber) 
        { 
            
            double result = (double)firstNumber / (double)secondNumber;

            return result;
        }

        public static double GetMultipli(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;

            return result;
        }

    }
}
