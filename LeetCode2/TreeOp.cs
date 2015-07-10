using System;

namespace LeetCode2
{
	public class TreeNode {
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }
	}

	public class TreeOp
	{	
		public bool BstCheck(TreeNode root)
		{
			if (root == null) {
				return true;
			}

			if (root.left != null) {
				if (root.left.val > root.val) 
				{
					return false;
				}	
			}

			if (root.right != null) {
				if (root.right.val < root.val) 
				{
					return false;
				}	
			}

			return BstCheck(root.left) && BstCheck (root.right);
		}

		public void PrintBst(TreeNode root)
		{
			if (root == null) {
				return;
			}
			PrintBst (root.left);
			Console.Write (root.val + " ");
			PrintBst (root.right);
		}
	
	}
}

