using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class MyList
    {
        private Node Head = null;

        public void Insert(object element)
        {
            Node newNode = new Node();
            newNode.Next = Head;
            Head = newNode;
            newNode.Data = element;
        }

        public void Insert(object element, int index)
        {
            Node newNode = new Node();
            newNode.Data = element;

            int counter = 0;
            Node pointer = Head;

            while (pointer != null && counter < index - 1)
            {
                counter++;
                pointer = pointer.Next;
            }

            

            newNode.Next = pointer.Next;
            pointer.Next = newNode;
        }


        public void Delete()
        {
            Node tmpNode = Head;
            Head = tmpNode.Next;
            tmpNode.Next = null;
        }

        public void Delete(int index)
        {
            int counter = 0;
            Node pointer = Head;

            while (pointer != null && counter < index - 1)
            {
                pointer = pointer.Next;
                counter++;
            }

            if (pointer == null)
            {
                throw new IndexOutOfRangeException();
            }

            Node tmpNode = pointer.Next;
            pointer.Next = tmpNode.Next;
            tmpNode.Next = null;
        }

        public object Search(int index)
        {
            int counter = 0;
            Node pointer = Head;
            while (pointer != null && counter < index)
            {
                counter++;
                pointer = pointer.Next;
            }

            if (pointer == null)
            {
                throw new IndexOutOfRangeException();
            }

            return pointer.Data;
        }

        public void SortByNumber()
        {
            Node pointer = Head;
            bool swapped = false;
            do
            {
                pointer = Head;
                swapped = false;
                while (pointer.Next != null)
                {
                    ClubMember a = (ClubMember)pointer.Data;
                    ClubMember b = (ClubMember)pointer.Next.Data;
                    if (a.Nr > b.Nr)
                    {
                        Change(pointer, pointer.Next);
                        swapped = true;
                    }
                    pointer = pointer.Next;
                }
            } while (swapped == true);
        }


        public void SortByFirstName()
        {
            Node pointer = Head;
            bool swapped = false;
            do
            {
                pointer = Head;
                swapped = false;
                while (pointer.Next != null)
                {
                    ClubMember a = (ClubMember)pointer.Data;
                    ClubMember b = (ClubMember)pointer.Next.Data;
                    if (string.Compare(a.Fname,b.Fname) == 1)
                    {
                        Change(pointer, pointer.Next);
                        swapped = true;
                    }
                    pointer = pointer.Next;
                }
            } while (swapped == true);
        }

        public void SortByAge()
        {
            Node pointer = Head;
            bool swapped = false;
            do
            {
                pointer = Head;
                swapped = false;
                while (pointer.Next != null)
                {
                    ClubMember a = (ClubMember)pointer.Data;
                    ClubMember b = (ClubMember)pointer.Next.Data;
                    if (a.Age > b.Age)
                    {
                        Change(pointer, pointer.Next);
                        swapped = true;
                    }
                    pointer = pointer.Next;
                }
            } while (swapped == true);
        }


        private void Change(Node nodeA, Node nodeB)
        {
            object tmpData = nodeA.Data;
            nodeA.Data = nodeB.Data;
            nodeB.Data = tmpData;
        }

        override public string ToString()
        {
            Node pointer = Head;
            string returnString = "";
            while (pointer != null)
            {
                returnString += pointer.Data.ToString() + "\n";
                pointer = pointer.Next;
            }

            return returnString;
        }
    }
}
