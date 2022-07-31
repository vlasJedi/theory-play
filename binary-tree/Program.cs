// See https://aka.ms/new-console-template for more information

namespace binary_tree;

class Program
    {
        public static void Main(string[] args)
        {
            var bTree = new BinaryTree();
            bTree.Insert("b", "value-b");
            bTree.Insert("a", "value-a");
            bTree.Insert("c", "value-c");
            bTree.Insert("ba", "value-ba");
            
        }
    }  
