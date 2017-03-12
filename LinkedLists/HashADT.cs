using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class HashADT
    {
        IComparable[] iCompArr;

        public HashADT(int size)
        {
            iCompArr = new IComparable[size];
        }

        public void Insert(IComparable data)
        {
            int hashCode = Math.Abs(data.GetHashCode());
            int index = hashCode % iCompArr.Length;
            iCompArr[index] = data;
        }

        public int Search(IComparable data)
        {
            int result = -1;
            int hashCode = Math.Abs(data.GetHashCode());
            int index = hashCode % iCompArr.Length;
            if (iCompArr[index].Equals(data))
            {
                result = index;
            }

            return result;
        }

        public IComparable GetElement(int idx)
        {
            IComparable data = iCompArr[idx];
            return data;
        }

        public bool IndexInUse(int idx)
        {
            bool result = false;

            if(iCompArr[idx] != null)
            {
                result = true;
            }

            return result;
        }
    }
}
