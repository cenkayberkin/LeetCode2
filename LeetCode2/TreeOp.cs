using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

		public void TreeLevelOrderPrintBottomUp(TreeNode root)
		{
			Queue<TreeNode> q = new Queue<TreeNode>();
			Stack<string> stack = new Stack<string> ();

			string tmp = "";

			int curCount = 1;
			int nextCount = 0;

			if (root == null) {
				return;
			}

			q.Enqueue (root);

			while (q.Count > 0) {
				var cur = q.Dequeue ();
				curCount -= 1;

				tmp += cur.val + " ";

				var left = cur.left;
				var right = cur.right;

				if (left != null) {
					q.Enqueue (left);
					nextCount += 1;
				}
				if (right != null) {
					q.Enqueue (right);	
					nextCount += 1;
				}
				if (curCount == 0) {
					stack.Push (tmp.TrimEnd(' '));
					tmp = "";
					curCount = nextCount;
					nextCount = 0;
				}

			}

			foreach (var item in stack.ToList()) {
				Console.WriteLine (item);
			}

		}

		public void TreeLevelOrderPrint(TreeNode root, Queue<TreeNode> q)
		{
			int curCount = 1;
			int nextCount = 0;

			if (root == null) {
				return;
			}

			q.Enqueue (root);

			while (q.Count > 0) {
				var cur = q.Dequeue ();
				curCount -= 1;
				
				Console.Write (cur.val + " ");

				var left = cur.left;
				var right = cur.right;

				if (left != null) {
					q.Enqueue (left);
					nextCount += 1;
				}
				if (right != null) {
					q.Enqueue (right);	
					nextCount += 1;
				}
				if (curCount == 0) {
					Console.WriteLine ("");
					curCount = nextCount;
					nextCount = 0;
				}

			}

		}

		public bool BstCheck2(TreeNode root,int[] last)
		{
			if (root == null) {
				return true;
			}

			var left = BstCheck2 (root.left,last);

			if (last[0] > root.val) {
				return false;
			}
			last[0] = root.val;

			var right = BstCheck2 (root.right, last);

			return left && right; 
		}

		public bool BstCheck(TreeNode root,int min = int.MinValue , int max = int.MaxValue)
		{
			if (root == null) {
				return true;
			}

			if (root.val > max || root.val < min) {
				return false;
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

			return BstCheck(root.left,min,root.val) && BstCheck (root.right,root.val ,max);
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

