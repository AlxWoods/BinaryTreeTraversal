using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinaryTreeTraversal
{
    public class InOrder
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>(); // List to store the traversal result
            InorderHelper(root, result); // Call the helper method to perform traversal
            return result; // Return the traversal result
        }

        private void InorderHelper(TreeNode node, List<int> result)
        {
            if (node != null)
            {
                InorderHelper(node.left, result); // Recursively traverse the left subtree
                result.Add(node.val); // Visit the current node (add its value to the result)
                InorderHelper(node.right, result); // Recursively traverse the right subtree
            }
        }
    }
}
