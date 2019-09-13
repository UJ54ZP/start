﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
    public class CountPrimeNumbers : SolutionProviderBase
    {
        private int upperLimit;

        public CountPrimeNumbers(int upperLimit)
        {
            this.upperLimit = upperLimit;
        }

        public override int CalculateSolution()
        {
            int db = 0;
            for(int i=2; i < upperLimit; i++)
            {
                if (IsPrime(i))
                {
                    db += i;
                }
            }
            return db;
        }

        private bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
