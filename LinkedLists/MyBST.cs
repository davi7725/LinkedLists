using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class MyBST
    {
        Node root = null;

        public void Insert(object data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (root == null)
            {
                newNode.Left = null;
                newNode.Right = null;

                root = newNode;
            }
            else
            {
                Node pointer = root;

                ClubMember cm = (ClubMember)newNode.Data;
                ClubMember pointerCm = (ClubMember)pointer.Data;

                bool foundCorrectPosition = false;
                string cmFnLn = cm.Fname + cm.Lname;

                while (foundCorrectPosition == false)
                {
                    string pointerFnLn = pointerCm.Fname + pointerCm.Lname;

                    if (string.Compare(cmFnLn,pointerFnLn) ==-1)
                    {
                        if (pointer.Left != null)
                        {
                            pointer = pointer.Left;
                            pointerCm = (ClubMember)pointer.Data;
                        }
                        else
                        {
                            pointer.Left = newNode;
                            foundCorrectPosition = true;
                        }
                    }
                    else
                    {
                        if (pointer.Right != null)
                        {
                            pointer = pointer.Right;
                            pointerCm = (ClubMember)pointer.Data;
                        }
                        else
                        {
                            pointer.Right = newNode;
                            foundCorrectPosition = true;
                        }
                    }
                }
            }
        }

        public bool Search(object data)
        {
            Node pointer = root;

            ClubMember cm = (ClubMember)data;
            ClubMember pointerCm = (ClubMember)pointer.Data;
            string cmFnLn = cm.Fname + cm.Lname;

            bool foundTheData = false;

            while (foundTheData == false && pointer != null)
            {
                pointerCm = (ClubMember)pointer.Data;
                string pointerFnLn = pointerCm.Fname + pointerCm.Lname;

                if(cm.Equals(pointerCm))
                {
                    foundTheData = true;
                }
                else
                {
                    if(string.Compare(cmFnLn, pointerFnLn) == 1)
                    {
                        pointer = pointer.Right;
                    }
                    else
                    {
                        pointer = pointer.Left;
                    }
                }
            }

            return foundTheData;
        }
    }
}
