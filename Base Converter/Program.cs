using System;

namespace Base_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string sBaseChoice;
            int[] nBaseChoice;
            bool IsInRange;
            bool IsInt;

            //Base to convert from
            IsInRange = false;
            while (IsInRange == false)
            {
                IsInt = false;
                while (IsInt == false)
                {
                    IsInt = true;
                    Console.WriteLine("What would you like to convert from");
                    Console.WriteLine("1. Binary");
                    Console.WriteLine("2. Denary");
                    Console.WriteLine("3. Hexidecimal");
                    sBaseChoice = Console.ReadLine();
                    try
                    {
                        nBaseChoice[0] = Convert.ToInt32(sBaseChoice);
                    }
                    catch
                    {
                        Console.WriteLine("Please enter an integer");
                        IsInt = false;                      
                    }
                }
                if (nBaseChoice[0] <= 3 && nBaseChoice[0] >= 1)
                {                   
                    IsInRange = true;
                }
            }
            
            //Base to convert to 
            IsInRange = false;
            while (IsInRange == false)
            {
                IsInt = false;
                while (IsInt == false)
                {
                    IsInt = true;
                    Console.WriteLine("What would you like to convert from");
                    Console.WriteLine("1. Binary");
                    Console.WriteLine("2. Denary");
                    Console.WriteLine("3. Hexidecimal");
                    sBaseChoice = Console.ReadLine();
                    try
                    {
                        nBaseChoice[1] = Convert.ToInt32(sBaseChoice);
                    }
                    catch
                    {
                        Console.WriteLine("Please enter an integer");
                        IsInt = false;
                    }
                }
                if (nBaseChoice[1] <= 3 && nBaseChoice[1] >= 1)
                {
                    IsInRange = true;
                }
            }
        }


        static void DtoB()
        {
            string sInput;
            int nInput;
            bool IsInt = false;
            while (IsInt == false)
            {
                IsInt = true;
                Console.WriteLine("Enter your denary number");
                sInput = Console.ReadLine();
                try
                {
                    nInput = Convert.ToInt32(sInput);
                }
                catch
                {
                    Console.WriteLine("Please enter an integer");
                    IsInt = false;
                }
            }

        }
    }
}
