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
            int[] nBaseChoice = new int[1];
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
            string Input;
            int len;
            double sum = 0;
            string digit;

            Console.WriteLine("Enter your denary number");
            Input = Console.ReadLine();
            len = Input.Length;

            for (int x = 0; x < len; x++)
            {
                digit = Input.Substring(len - x - 1, len - x);
                if (digit == "1")
                {
                    sum = sum + Math.Pow(2, x);
                }                
            }

        }
    }
}
