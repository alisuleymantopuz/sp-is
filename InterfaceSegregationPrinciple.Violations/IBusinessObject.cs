using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Violations
{
    public interface IBusinessObject
    {
        void Save();
        void Delete();
        bool Validate();
    }
}
