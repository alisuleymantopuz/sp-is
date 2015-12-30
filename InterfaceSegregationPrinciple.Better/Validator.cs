using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Better
{
    public class Validator
    {
        public void Validate(IEnumerable<IValidatable> validatables)
        {
            if (validatables != null)
            {
                foreach (var validatable in validatables)
                {
                    validatable.Validate();
                }
            }
        }
    }
}
