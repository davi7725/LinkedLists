using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class ClubMember : IComparable
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

        public int CompareTo(object o)
        {
            int result = 0;
            ClubMember cm = (ClubMember)o;

            if(cm.Nr > this.Nr)
            {
                result = 1;
            }
            else if(cm.Nr<this.Nr)
            {
                result = -1;
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            bool areEqual = false;
            ClubMember cm = (ClubMember)obj;

            if(cm.Nr == this.Nr && cm.Fname == this.Fname && cm.Lname == this.Lname && cm.Age == this.Age)
            {
                areEqual = true;
            }

            return areEqual;
        }

        public override int GetHashCode()
        {
            return Age.GetHashCode() + Fname.GetHashCode() + Lname.GetHashCode() + Nr.GetHashCode();
        }

        public override string ToString()
        {
            return Nr + " " + Fname + " " + Lname + " " + Age;
        }
    }
}
