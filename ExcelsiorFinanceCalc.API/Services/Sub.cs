using ExcelsiorFinanceCalc.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelsiorFinanceCalc.API.Services
{
    public class Sub : ISub
    {
        public decimal Calculate(int NumberOne, int NumberTwo)
        {
            return NumberOne - NumberTwo;
        }
    }
}
