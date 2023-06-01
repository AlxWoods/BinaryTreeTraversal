using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTraversal
{
    internal class PreOrder
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>(); // List to store the traversal result
            PreorderHelper(root, result); // Call the helper method to perform traversal
            return result; // Return the traversal result
        }

        private void PreorderHelper(TreeNode node, List<int> result)
        {
            if (node != null)
            {
                result.Add(node.val); // Visit the current node (add its value to the result)
                PreorderHelper(node.left, result); // Recursively traverse the left subtree
                PreorderHelper(node.right, result); // Recursively traverse the right subtree
            }
        }
    }
}
