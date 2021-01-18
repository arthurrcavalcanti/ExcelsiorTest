using ExcelsiorFinanceCalc.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelsiorFinanceCalc.API.Services
{
    public class Div : IDiv
    {
        public decimal Calculate(int NumberOne, int NumberTwo)
        {
            if (NumberTwo != 0)
            {
                return NumberOne / NumberTwo;
            }
            else
            {
                throw new Exception("NumberTwo não pode ser 0!");
            }
        }
    }
}
