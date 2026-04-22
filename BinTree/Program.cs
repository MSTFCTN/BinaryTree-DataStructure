using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BinTree.DataStructures;

namespace BinTree
{
    class Program
    {
        static void Main()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(85);
            tree.Insert(97);
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3312);
            tree.Insert(0);

            tree.InOrder();
            tree.Remove(3);
            tree.InOrder();
        }
    }
}