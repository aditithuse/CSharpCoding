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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return Construct(nums,0,nums.Length);
    }
    
    public TreeNode Construct(int[] nums, int left, int right){
        
        if(left==right) return null;
        
        int max = CalculateMax(nums, left, right);        
        TreeNode root = new TreeNode(nums[max]);
        root.left = Construct(nums,left,max);
        root.right = Construct(nums,max+1,right);
        
        return root;
    }
    
    public int CalculateMax(int[] nums, int left, int right){
        int max=left;
        for(int i=left ; i < right; i++)
            if(nums[max]<nums[i])
                max=i;
        
        return max;
    }   
}
