/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Any())
        {
            var size = queue.Count;
            
            var oneResult = new List<int>();
            for (int z = 0; z < size; z++)
            {
                var cur = queue.Dequeue();
                oneResult.Add(cur.val);

                if (cur.left != null) queue.Enqueue(cur.left);
                if (cur.right != null) queue.Enqueue(cur.right);
            }
            result.Add(oneResult);
        }

        return result;
    }
}
