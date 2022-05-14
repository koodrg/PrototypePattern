using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public interface Prototype
    {
        public Object ShallowCopy();
        public Object DeepCopy();
    }
}
