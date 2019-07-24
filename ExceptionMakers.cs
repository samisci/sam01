using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class ExceptionMakers
    {
        public Exception HackerUDivideByZero = new Exception("div by zero");
        public Exception HackerUFormatException = new Exception("HackerUFormat");
        public Exception HackerUIndexOutOfRangeException = new Exception("HackerUIndexOutOfRangeException");
        
        public int GetNumber()

        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                throw HackerUFormatException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int[] GetNumbers()
        {
            int[] numbers = new int[4];
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                return numbers;
            }
            catch (IndexOutOfRangeException ex)
            {
                throw HackerUIndexOutOfRangeException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DivideByZero()
        {
            try
            {
                int x = 0;
                x = 10 / x;
            }
            catch (DivideByZeroException ex)
            {
                
                throw HackerUDivideByZero;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
