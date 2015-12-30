using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Better
{
    public class DbContext
    {
        public void Save(IEnumerable<IPersistable> persistables)
        {
            if (persistables != null)
            {
                foreach (var persistable in persistables)
                {
                    persistable.Save();
                }
            }
        }

        public void Delete(IEnumerable<IPersistable> persistables)
        {
            if (persistables != null)
            {
                foreach (var persistable in persistables)
                {
                    persistable.Delete();
                }
            }
        }

        public void Delete(IEnumerable<IValidatable> persistables)
        {
            if (persistables != null)
            {
                foreach (var persistable in persistables)
                {
                    persistable.Validate();
                }
            }
        }
    }
}
