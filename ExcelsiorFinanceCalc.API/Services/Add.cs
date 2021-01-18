using ExcelsiorFinanceCalc.API.Interfaces;
using System;

namespace ExcelsiorFinanceCalc.API
{
    public class Add : IAdd
    {
        public decimal Calculate(int NumberOne, int NumberTwo)
        {
            return NumberOne + NumberTwo;
        }
    }
}
