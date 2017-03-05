using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class ClubMember
    {
        public int Nr { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public ClubMember(int nr, string fname, string lname, int age)
        {
            Nr = nr;
            Fname = fname;
            Lname = lname;
            Age = age;
        }

        public override string ToString()
        {
            return Nr + " " + Fname + " " + Lname + " " + Age;
        }
    }
}
