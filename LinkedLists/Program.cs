using System;
using System.Diagnostics;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProg = new Program();
            myProg.Run();
        }

        private void Run()
        {

            //TODO: Make arrays and random cm's to be the same for all searches!!!

            /*********** LINKED LISTS ***********/
            /*
            MyList myList = new MyList();
            */
            ClubMember cm1 = new ClubMember(1, "John", "Doe", 25);
            ClubMember cm2 = new ClubMember(2, "Ben", "Smith", 40);
            ClubMember cm3 = new ClubMember(3, "Josh", "Yansen", 20);
            ClubMember cm4 = new ClubMember(4, "Annah", "Dobrev", 30);
            ClubMember cm5 = new ClubMember(5, "Yolad", "Fjaos", 30);
            /*
            myList.Insert(cm4);
            myList.Insert(cm3);
            myList.Insert(cm2);
            myList.Insert(cm1);

            Console.WriteLine(myList.ToString());

            Console.WriteLine(myList.IndexOf(cm4));*/
            /*********** LINKED LISTS END ***********/
            /*********** EXSORTANDSEARCH01 ***********/
            
            int smallSize = 1000;
            int largeSize = smallSize * 2;
            /*
            ClubMember[] smallLinear = new ClubMember[smallSize];
            ClubMember[] largeLinear = new ClubMember[largeSize];

            ClubMember[] smallBinary = new ClubMember[smallSize];
            ClubMember[] largeBinary = new ClubMember[largeSize];

            ArrayFill(smallLinear);
            ArrayFill(largeLinear);
            ArrayFill(smallBinary);
            ArrayFill(largeBinary);

            SearchLinear(smallLinear);
            SearchLinear(largeLinear);


            SearchBinary(smallBinary);
            SearchBinary(largeBinary);

            ClubMember[] smallCmArr = new ClubMember[smallSize];
            MyBST smallBst = new MyBST();
            ClubMember[] largCmArr = new ClubMember[largeSize];
            MyBST largeBst = new MyBST();

            TreeFill(smallBst, smallSize, smallCmArr);
            TreeFill(largeBst, largeSize, largCmArr);

            SearchBst(smallBst, smallCmArr);
            SearchBst(largeBst, largCmArr);
            /*********** EXSORTANDSEARCH01 END ***********/

            /*********** EXSORTANDSEARCH02 ***********/
            /*
            HashADT smallHash = new HashADT(smallSize);
            HashADT largeHash = new HashADT(largeSize);

            HashAdtFill(smallHash, smallSize);
            HashAdtFill(largeHash, largeSize);

            SearchHashAdt(smallHash, smallSize);
            SearchHashAdt(largeHash, largeSize);*/
            /*********** EXSORTANDSEARCH02 END ***********/

            HeapADT heap = new HeapADT(smallSize);

            heap.Insert(cm1);
            heap.Insert(cm2);
            heap.Insert(cm5);
            heap.Insert(cm2);
            heap.Insert(cm3);
            heap.Insert(cm5);
            heap.Insert(cm4);
            heap.Insert(cm3);
            heap.Insert(cm4);
            heap.Insert(cm5);
            heap.Insert(cm3);
            heap.Insert(cm4);
            heap.Insert(cm5);
            heap.Insert(cm3);
            heap.Insert(cm1);
            heap.Insert(cm5);
            heap.Insert(cm2);

            heap.showArray();

            IComparable[] sorted = heap.GetSortedArray();

            Console.WriteLine("SORTED ARRAY: ");
            
            foreach(IComparable ic in sorted)

            {
                ClubMember mc = (ClubMember)ic;
                if (mc != null)
                    Console.Write(" " + mc.Nr);
            }
            Console.ReadKey();

        }

        public void HashAdtFill(HashADT hashObj, int size)
        {
            int properSize = size + (size / 10);
            for (int i = 0; i < properSize; i++)
            {
                ClubMember cm = CMFactory.GetClubMember();
                hashObj.Insert(cm);
            }
        }

        public void TreeFill(MyBST bst, int size, ClubMember[] arr)
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = CMFactory.GetClubMember();
                bst.Insert(arr[i]);
            }
        }

        public void ArrayFill(ClubMember[] cmArray)
        {
            for (int i = 0; i < cmArray.Length; i++)
            {
                cmArray[i] = CMFactory.GetClubMember();
            }
        }

        public void SearchHashAdt(HashADT hashObj, int size)
        {
            Random rnd = new Random();
            ClubMember cm1 = null;
            ClubMember cm2 = null;
            ClubMember cm3 = null;

            while (cm1 == null)
            {
               cm1 = (ClubMember)hashObj.GetElement(rnd.Next(0, size - 1));
            }
            while (cm2 == null)
            {
                cm2 = (ClubMember)hashObj.GetElement(rnd.Next(0, size - 1));
            }
            while (cm3 == null)
            {
                cm3 = (ClubMember)hashObj.GetElement(rnd.Next(0, size - 1));
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for(int i = 0; i<1000; i++)
            {
                hashObj.Search(cm1);
                hashObj.Search(cm2);
                hashObj.Search(cm3);
            }

            sw.Stop();
            Console.WriteLine("HashADT stopwatch(" + size + ") " + sw.Elapsed);
        }

        public void SearchBst(MyBST bst, ClubMember[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();

            Random rnd = new Random();

            int random = rnd.Next(0, arr.Length - 1);
            ClubMember cm1 = arr[random];

            random = rnd.Next(0, arr.Length - 1);
            ClubMember cm2 = arr[random];

            random = rnd.Next(0, arr.Length - 1);
            ClubMember cm3 = arr[random];

            for (int i = 0; i < 1000; i++)
            {
                while (bst.Search(cm1) == false)
                {

                }
                while (bst.Search(cm2) == false)
                {

                }
                while (bst.Search(cm3) == false)
                {

                }
            }


            Console.WriteLine("Tree stopwatch(" + arr.Length + ") " + sw.Elapsed);
        }

        public void SearchBinary(IComparable[] array)
        {

            Stopwatch sw = new Stopwatch();
            sw.Restart();

            ClubMember[] arr = InsertionSort((ClubMember[])array);
            Random rnd = new Random();

            int random = rnd.Next(0, arr.Length - 1);
            ClubMember cm1 = arr[random];

            random = rnd.Next(0, arr.Length - 1);
            ClubMember cm2 = arr[random];

            random = rnd.Next(0, arr.Length - 1);
            ClubMember cm3 = arr[random];


            for (int i = 0; i < 1000; i++)
            {
                bool foundTheData = false;
                int startIndex = 0;
                int endIndex = arr.Length - 1;
                int distance = 1000;
                while (distance > 1 && foundTheData == false)
                {
                    distance = endIndex - startIndex;
                    int half = (distance / 2) + startIndex;


                    if (arr[half].Nr > cm1.Nr)
                    {
                        endIndex = half;
                    }
                    else if (arr[half].Nr < cm1.Nr)
                    {
                        startIndex = distance / 2 + startIndex;
                    }
                    else
                    {
                        foundTheData = true;
                    }
                }
                foundTheData = false;
                startIndex = 0;
                endIndex = arr.Length - 1;
                distance = 1000;
                while (distance > 1 && foundTheData == false)
                {
                    distance = endIndex - startIndex;
                    int half = (distance / 2) + startIndex;


                    if (arr[half].Nr > cm2.Nr)
                    {
                        endIndex = half;
                    }
                    else if (arr[half].Nr < cm2.Nr)
                    {
                        startIndex = distance / 2 + startIndex;
                    }
                    else
                    {
                        foundTheData = true;
                    }
                }

                foundTheData = false;
                startIndex = 0;
                endIndex = arr.Length - 1;
                distance = 1000;
                while (distance > 1 && foundTheData == false)
                {
                    distance = endIndex - startIndex;
                    int half = (distance / 2) + startIndex;


                    if (arr[half].Nr > cm3.Nr)
                    {
                        endIndex = half;
                    }
                    else if (arr[half].Nr < cm3.Nr)
                    {
                        startIndex = distance / 2 + startIndex;
                    }
                    else
                    {
                        foundTheData = true;
                    }
                }

            }
            Console.WriteLine("Binary stopwatch(" + arr.Length + ") " + sw.Elapsed);

        }

        public ClubMember[] InsertionSort(ClubMember[] arr)
        {
            ClubMember[] sortedArray = new ClubMember[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {

                sortedArray[i] = arr[i];

                for (int j = i; j > 0; j--)
                {
                    if (sortedArray[j].Nr < sortedArray[j - 1].Nr)
                    {
                        ClubMember tmpClubMember = sortedArray[j];
                        sortedArray[j] = sortedArray[j - 1];
                        sortedArray[j - 1] = tmpClubMember;
                    }
                }

            }


            return sortedArray;
        }

        public void SearchLinear(IComparable[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            Random rnd = new Random();

            int random = rnd.Next(0, arr.Length - 1);
            ClubMember cm1 = (ClubMember)arr[random];

            random = rnd.Next(0, arr.Length - 1);
            ClubMember cm2 = (ClubMember)arr[random];

            random = rnd.Next(0, arr.Length - 1);
            ClubMember cm3 = (ClubMember)arr[random];

            bool foundTheData = false;
            int index = 0;

            for (int i = 0; i < 1000; i++)
            {
                while (foundTheData == false)
                {
                    ClubMember cm = (ClubMember)arr[index];
                    if (cm.Equals(cm1))
                    {
                        foundTheData = true;
                    }
                    index++;


                }

                index = 0;
                foundTheData = false;

                while (foundTheData == false)
                {
                    ClubMember cm = (ClubMember)arr[index];
                    if (cm.Equals(cm2))
                    {
                        foundTheData = true;
                    }
                    index++;
                }

                index = 0;
                foundTheData = false;
                while (foundTheData == false)
                {
                    ClubMember cm = (ClubMember)arr[index];
                    if (cm.Equals(cm3))
                    {
                        foundTheData = true;
                    }
                    index++;
                }
                index = 0;
                foundTheData = false;

            }
            Console.WriteLine("Linear stopwatch(" + arr.Length + ") " + sw.Elapsed);
        }
    }
}
