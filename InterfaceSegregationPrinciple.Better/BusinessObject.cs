using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Better
{
    public class BusinessObject : IBusinessObject, IValidatable, IPersistable
    {

        public void Save()
        {
            //save code
        }

        public void Delete()
        {
            //delete code
        }

        public void Validate()
        {
            throw new Exception("is not valid");
        }
    }
}
