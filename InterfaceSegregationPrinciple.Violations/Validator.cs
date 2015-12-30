using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Violations
{
    public class Validator
    {
        public void Validate(IEnumerable<IBusinessObject> businessObjects)
        {
            if (businessObjects != null)
            {
                foreach (var businessObject in businessObjects)
                {
                    businessObject.Validate();
                }
            }
        }
    }
}
