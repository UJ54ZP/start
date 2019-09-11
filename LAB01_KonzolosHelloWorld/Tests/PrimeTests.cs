using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Numbers;

namespace Tests
{
    public class PrimeTests
    {
        [Fact]
        public void CountPrimeNumbers100Returns25()
        {
            var p = new CountPrimeNumbers(100);
            Assert.Equal(25, p.CalculateSolution());

        }
    }
}
