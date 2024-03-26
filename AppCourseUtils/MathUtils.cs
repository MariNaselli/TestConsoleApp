﻿namespace AppCourseUtils
{
    public class MathUtils
    {
        public static uint FactorialRec_v1(uint n) =>
            n == 0u ? 1 : n* FactorialRec_v1(n - 1);
      
        public static uint FactorialRec_v2(uint n)
        {
            if (n == 0u)
            {
                return 1;
            }

            return n * FactorialRec_v2(n - 1);        
        }

        public static uint FactorialRec_v3(uint n) =>
       
       n switch
       {
           0 => 1,
           uint k => k * FactorialRec_v3(k - 1)
       };

        public static uint FactorialIter(uint n)
        {
            if (n == 0u) 
                return 1;

            uint factorial = 1; 
            for (uint i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

 
        public static uint FibonacciRec(uint n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonacciRec(n - 1) + FibonacciRec(n - 2);
            }
        }

       
        public static uint FibonacciIter(uint n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            uint a = 0;
            uint b = 1;
            uint resultado = 0;

            for (uint i = 2; i <= n; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }

            return resultado;
        }

     

    }
}
