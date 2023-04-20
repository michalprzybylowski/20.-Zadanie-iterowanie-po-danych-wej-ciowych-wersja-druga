using System;


namespace Tablice
{
    class Program
    {

        static void Main(string[] args)
        {

            int? FirstuserInput = null;
            int TotalAmount = 0;
            int PreviousUserInput = 0;
            int HighestNumber = 0;
            while (FirstuserInput != 0)
            {
                string StringUserInput = Console.ReadLine();
                int UserInput = int.Parse(StringUserInput);
                PreviousUserInput = TotalAmount;
                TotalAmount = UserInput + PreviousUserInput;
                PreviousUserInput = TotalAmount;
                
                if (UserInput > HighestNumber)
                {
                    HighestNumber = UserInput;
                }
               FirstuserInput = UserInput;

            }
            Console.WriteLine(TotalAmount);
            Console.WriteLine("HighestNumber = " + HighestNumber);

        }
    }
}