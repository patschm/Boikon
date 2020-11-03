using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boikon.WebApi.Services
{
    public class RekenMachine : IRekenMachine
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
