using CodeChallenge4.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge4.Concrete
{
    public class DistanceClass : IDistance
    {
        public int Add(int d1, int d2)
        {
            return d1 + d2;
        }
    }
}
