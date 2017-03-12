using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class HeapADT
    {
        IComparable[] iCompArr;
        private int index = 0;

        public HeapADT(int size)
        {
            iCompArr = new IComparable[size];
        }

        public void Insert(IComparable data)
        {
            iCompArr[index] = data;
            int currentPos = index;

            while (iCompArr[currentPos].CompareTo(iCompArr[(currentPos - 1) / 2]) == -1)
            {
                IComparable tmpData = iCompArr[currentPos];
                iCompArr[currentPos] = iCompArr[(currentPos - 1) / 2];
                iCompArr[(currentPos - 1) / 2] = tmpData;
                currentPos = (currentPos - 1) / 2;
            }
            index++;
        }

        public IComparable GetLargest()
        {
            IComparable root = iCompArr[0];

            iCompArr[0] = iCompArr[index - 1];
            iCompArr[index - 1] = null;

            int currentPos = 0;
            int leftChild = 1;
            int rightChild = 2;
            bool foundTheRightSpot = false;

            while (foundTheRightSpot == false && iCompArr[currentPos + 1] != null)
            {
                showArray();

                if (iCompArr[rightChild] != null)
                {
                    if (iCompArr[leftChild].CompareTo(iCompArr[rightChild]) == -1)
                    {
                        if (iCompArr[currentPos].CompareTo(iCompArr[leftChild]) == 1)
                        {
                            IComparable tmpComp = iCompArr[currentPos];
                            iCompArr[currentPos] = iCompArr[leftChild];
                            iCompArr[leftChild] = tmpComp;
                            currentPos = leftChild;
                            leftChild = 2 * currentPos + 1;
                            rightChild = 2 * currentPos + 2;
                        }
                    }
                    else
                    {
                        if (iCompArr[currentPos].CompareTo(iCompArr[rightChild]) == 0)
                        {
                            foundTheRightSpot = true;
                        }
                         else if (iCompArr[currentPos].CompareTo(iCompArr[rightChild]) == 1)
                        {
                            IComparable tmpComp = iCompArr[currentPos];
                            iCompArr[currentPos] = iCompArr[rightChild];
                            iCompArr[rightChild] = tmpComp;
                            currentPos = rightChild;
                            leftChild = 2 * currentPos + 1;
                            rightChild = 2 * currentPos + 2;
                        }
                    }
                }
                else
                {
                    if (iCompArr[leftChild] != null)
                    {
                        if (iCompArr[currentPos].CompareTo(iCompArr[leftChild]) == 1)
                        {
                            IComparable tmpComp = iCompArr[currentPos];
                            iCompArr[currentPos] = iCompArr[leftChild];
                            iCompArr[leftChild] = tmpComp;
                            currentPos = leftChild;
                            leftChild = 2 * currentPos + 1;
                            rightChild = 2 * currentPos + 2;
                        }
                        else
                        {
                            foundTheRightSpot = true;
                        }
                    }
                    else
                    {
                        foundTheRightSpot = true;
                    }
                }

            }

            index--;
            return root;
        }

        public IComparable[] GetSortedArray()
        {
            int pos = 0;
            int newIndex = index - 1;
            IComparable[] sortedArr = new IComparable[iCompArr.Length];
            while (pos < newIndex+1)
            {
                sortedArr[newIndex - pos] = this.GetLargest();
                pos++;
            }

            return sortedArr;
        }

        public void showArray()
        {
            foreach(IComparable ic in iCompArr)
            {
                ClubMember cm = (ClubMember)ic;
                if (cm != null)
                    Console.Write(cm.Nr + " ");
            }
            Console.Write("\n");
        }
    }
}
