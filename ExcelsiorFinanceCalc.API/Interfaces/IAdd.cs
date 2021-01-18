using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelsiorFinanceCalc.API.Interfaces
{
    public interface IAdd
    {
        public decimal Calculate(int NumberOne, int NumberTwo);
    }
}
