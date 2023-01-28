namespace Troubleshooting
{
    public class ArbitraryCalculator
    {
        private int lastResult = 0;
        private int numberOfCalculations = 0;

        public int StartingNumber { get; }

        public int NumberOfCalculations { get
            {
                return this.numberOfCalculations;
            }
        }

        public int LastResultDoubled
        {
            get
            {
                return this.lastResult * 2;
            }
        }

        public ArbitraryCalculator(int startingNumber)
        {
            this.StartingNumber = startingNumber;

            if (startingNumber > 6)
            {
                this.StartingNumber = 6;
            }
        }

        public int Calculate(int number1, int number2)
        {
            int result = 0;

            // Remember, % is the remainder or modulus operator. It gives the remainder after division
            // So 9 % 7 = 2. Because 9/7 is 1 and 2/7.
            for (int i = 0; i < number1 % 11; i++)
            {
                for (int j = number2 % 3; j > 0; j--)
                {
                    if (i == j)
                    {
                        result += i + j;
                    }
                    else if (i < this.StartingNumber)
                    {
                        result += i;
                    }
                    else if (i > this.StartingNumber)
                    {
                        result += j;
                    }

                    this.numberOfCalculations++;
                }
            }

            this.lastResult = result;
            return result;
        }
    }
}