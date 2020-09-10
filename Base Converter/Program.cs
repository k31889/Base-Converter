using System;

namespace Base_Converter
{
    class Program
    {
        //remove writelines from conversion subroutines and use parameters instead
        static void Main(string[] args)
        {
            DtoH();
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

        static void DtoH()
        {
            string sInput;
            int dNum;
            int[] hNum = new int[31];

            Console.WriteLine("Enter your denary number");
            sInput = Console.ReadLine();
            dNum = Convert.ToInt32(sInput);
           
        }
        static void BtoD()
        {
            string Input;
            int len;
            double sum = 0;

            Console.WriteLine("Enter your binary number");
            Input = Console.ReadLine();
            len = Input.Length;

            for (int x = 0; x < len; x++)
            {
                if (Input[len - (x +     1)] == '1')
                {
                    sum = sum + Math.Pow(2, x);
                }                
            }
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
