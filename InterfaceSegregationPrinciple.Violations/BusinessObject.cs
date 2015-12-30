using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Violations
{
    public class BusinessObject : IBusinessObject
    {
        public void Save()
        {
            //save code here
        }

        public void Delete()
        {
            //delete code here
        }

        public bool Validate()
        {
            //validate code here
            return false;
        }
    }
}
