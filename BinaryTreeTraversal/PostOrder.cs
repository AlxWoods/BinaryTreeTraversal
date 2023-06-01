using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTraversal
{
    internal class PostOrder
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>(); // List to store the traversal result
            PostorderHelper(root, result); // Call the helper method to perform traversal
            return result; // Return the traversal result
        }

        private void PostorderHelper(TreeNode node, List<int> result)
        {
            if (node != null)
            {
                PostorderHelper(node.left, result); // Recursively traverse the left subtree
                PostorderHelper(node.right, result); // Recursively traverse the right subtree
                result.Add(node.val); // Visit the current node (add its value to the result)
            }
        }
    }
}
