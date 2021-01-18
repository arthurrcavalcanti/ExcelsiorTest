using ExcelsiorFinanceCalc.API.Interfaces;
using System;

namespace ExcelsiorFinanceCalc.API.Services
{
    public class Mult : IMult
    {
        public decimal Calculate(int NumberOne, int NumberTwo)
        {
            return NumberOne * NumberTwo;
        }
    }
}
