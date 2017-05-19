using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace BinaryTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test int
            Tree<int> intTree = new Tree<int>(10);
            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
                int temp = r.Next(0, 20);
                intTree.Insert(temp);
            }

            string sortedData = intTree.WalkTree();
            Console.WriteLine(sortedData);
            #endregion

            #region Test String
            Tree<string> strTree = new Tree<string>("Mid");
            strTree.Insert("World");
            strTree.Insert("How");
            strTree.Insert("Are");
            strTree.Insert("You");
            strTree.Insert("Today");
            strTree.Insert("I");
            strTree.Insert("Hope");
            strTree.Insert("You");
            strTree.Insert("Are");
            strTree.Insert("Feeling");
            strTree.Insert("Well");

            string sortedStrTee = strTree.WalkTree();
            Console.WriteLine(sortedStrTee);
            #endregion

            #region ToKeepWindowOpen
            Console.WriteLine("Please press enter:");
            Console.ReadLine();
            #endregion
        }
    }
}
