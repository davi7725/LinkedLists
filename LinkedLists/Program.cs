using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            MyList myList = new MyList();

            ClubMember cm1 = new ClubMember(1, "John", "Doe", 25);
            ClubMember cm2 = new ClubMember(2, "Ben", "Smith", 40);
            ClubMember cm3 = new ClubMember(3, "Josh", "Yansen", 20);
            ClubMember cm4 = new ClubMember(4, "Annah", "Dobrev", 30);

            myList.Insert(cm4);
            myList.Insert(cm3);
            myList.Insert(cm2);
            myList.Insert(cm1);

            Console.WriteLine(myList.ToString());

            myList.Insert(cm1, 4);

            myList.Insert(cm2, 2);

            Console.WriteLine(myList.ToString());
            myList.SortByAge();
            Console.WriteLine(myList.ToString());
            Console.ReadKey();

        }
    }
}
