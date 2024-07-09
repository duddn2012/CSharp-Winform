using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1.Collections
{
    class CustomList<T> : ICustomEnumerable
    {
        T[] data;
        int current;

        public ICustomEnumerator GetEnumerator() => new CustomEnumerator(this);

        public CustomList(params T[] datas)
        {

            data = new T[datas.Length];
            for (int i = 0; i < datas.Length; i++)
            {
                data[i] = datas[i];
            }
        }

        public struct CustomEnumerator : ICustomEnumerator
        {
            private CustomList<T> customList;

            public CustomEnumerator(CustomList<T> customList) : this()
            {
                this.customList = customList;
            }

            public object Current => customList.data[customList.current];

            public void MoveNext()
            {
                if (customList.current >= customList.data.Length - 1)
                {
                    Rest();
                }
                else
                {
                    customList.current++;
                }                
            }

            public void Rest()
            {
                customList.current = 0;
            }
        }
    }
}
