using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1.Collections
{
    interface ICustomEnumerator
    {
        object Current { get; }
        void MoveNext();
        void Rest();
    }
}
