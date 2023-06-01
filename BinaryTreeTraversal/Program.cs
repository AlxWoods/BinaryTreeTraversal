using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a binary tree
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            // Create an instance of for each search class
            InOrder inOrder = new InOrder();
            PreOrder preOrder = new PreOrder();
            PostOrder postOrder = new PostOrder();

            // Invoke the each method
            IList<int> inOrderTraversalResult = inOrder.InorderTraversal(root);
            IList<int> postOrderTraversalResult = postOrder.PostorderTraversal(root);
            IList<int> preOrderTraversalResult = preOrder.PreorderTraversal(root);

            Console.WriteLine("\nPre-order Traversal:");
            foreach (int val in preOrderTraversalResult)
            {
                Console.Write(val + " ");
            }
            // Print the traversal results
            Console.WriteLine("\nIn-order Traversal:");
            foreach (int val in inOrderTraversalResult)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("\nPost-order Traversal:");
            foreach (int val in postOrderTraversalResult)
            {
                Console.Write(val + " ");
            }
        }
    }
}