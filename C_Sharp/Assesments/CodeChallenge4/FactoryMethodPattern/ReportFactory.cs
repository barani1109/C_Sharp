using FactoryMethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factories
{
    public abstract class ReportFactory
    {
        public abstract IReport CreateReport();
    }
}
