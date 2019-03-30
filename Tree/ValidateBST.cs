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
    public bool IsValidBST(TreeNode root) {
        return IsValid(root, long.MinValue, long.MaxValue);
    }
    
    private bool IsValid(TreeNode root, long min, long max)
    {
        if (root == null)
            return true;
        
        if (root.val >= max || root.val <= min)
            return false;
        
        return IsValid(root.left,min,root.val) && IsValid(root.right,root.val,max);        
    }
}
