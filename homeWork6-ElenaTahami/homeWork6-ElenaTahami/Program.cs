using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork6_ElenaTahami
{
    class Program
    {
        public static void Main()
        {
            ShowMenu showMenu = new ShowMenu();
            showMenu.DisplayMenu();
            Console.WriteLine("Select an option:");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    RunFibonacci();
                    break;
                case 2:
                    RunPrimeChecker();
                    break;
                case 3:
                    RunLongestIncreasingSubarray();
                    break;
                case 4:
                    RunTargetSum();
                    break;
                case 5:
                    RunConvertNumberToEnglish();
                    break;
                case 6:
                    RunFindFirstNonRepeating();
                    break;
                case 7:
                    RunReverseNumber();               
                    break;
                case 8:
                    RunTriangle_Validation();
                    break;
                case 9:

                    break;
                case 10:
                    RunMaximumOfProductThreetNumbers();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        private static void RunFibonacci()
        {
            Console.Write("Enter Your Number:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            Fibonacci fibonacci = new Fibonacci();
            Console.WriteLine(fibonacci.Calculate(n));
        }
        private static void RunPrimeChecker()
        {
            int inputNum = Convert.ToInt32(Console.ReadLine());
            PrimeValidator prime = new PrimeValidator();
            Console.WriteLine(prime.CheckerPrime(inputNum));
        }
        private static void RunLongestIncreasingSubarray()
        {
            Console.WriteLine("Enter LenghtArray");
            int lenghtArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Numbers");
            int[] array = new int[lenghtArray];
            for (int i = 0; i < lenghtArray; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            LongestIncreasingSubarray subarray = new LongestIncreasingSubarray();
            Console.WriteLine(subarray.FindLongestLength(array));
        }
        private static void RunTargetSum()
        {
            Console.WriteLine("Enter LenghtArray");
            int lenghtarrayTargetSum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter target");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Numbers");
            int[] arraySum = new int[lenghtarrayTargetSum];
            for (int i = 0; i < lenghtarrayTargetSum; i++)
            {
                arraySum[i] = Convert.ToInt32(Console.ReadLine());
            }
            TargetSumFinder targetSumFinder = new TargetSumFinder();
            Console.WriteLine(targetSumFinder.SumFinder(arraySum, target));
        }
        private static void RunTriangle_Validation()
        {
            Console.WriteLine("Enter LenghtArray");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Numbers");
            int[] arrayNumbers = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            TriangleValidation triangle_Validation = new TriangleValidation();
            Console.WriteLine(triangle_Validation.CalculateTriangleValidation(arrayNumbers));
        }
        private static void RunFindFirstNonRepeating()
        {
            FirstNonRepeatingCharacter finder = new FirstNonRepeatingCharacter();
            Console.WriteLine("Enter Your Text ");
            string text=Console.ReadLine() ?? "";
            int result = finder.FindFirstNonRepeating(text);
            if (result == -1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine((char)result);
            }
       
        }
        private static void RunConvertNumberToEnglish()
        {
            Console.Write("Enter Your Number:  ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            NamberToEnglishWord number=new NamberToEnglishWord();
            Console.WriteLine(number.NumberToEnglishWord(inputNumber));
        }

        private static void RunReverseNumber()
        {
            Console.Write("Enter Your Number:  ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            ReverseInputNumber reverseNumber = new ReverseInputNumber();
            Console.WriteLine(reverseNumber.ReverseInteger(inputNumber));
        }


        private static void RunMaximumOfProductThreetNumbers()
        {
            Console.WriteLine("Enter LenghtArray");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Numbers");
            long[] arrayNumbers = new long[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                arrayNumbers[i] = Convert.ToInt64 (Console.ReadLine());
            }
            MaximumProductOf_ThreeNumbers maximumProductOf_Three= new MaximumProductOf_ThreeNumbers();

            Console.WriteLine(maximumProductOf_Three.MaximumOfProductThreeNumber(arrayNumbers));
        }

    }
}


