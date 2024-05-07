namespace PatternProblems
{
    internal class Patterns
    {
        public void Pattern1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");

            }
        }

        public void Pattern2()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }
        }

        public void Pattern3()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j + 1);
                }

                Console.WriteLine("\n");
            }
        }

        public void Pattern4()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + 1);
                }

                Console.WriteLine("\n");
            }
        }

        public void Pattern5()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("\n");
            }
        }

    }
}
