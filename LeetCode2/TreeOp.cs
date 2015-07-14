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
		public void Flatten(TreeNode root) 
		{
			if (root == null) {
				return;
			}
			List<TreeNode> arr = new List<TreeNode> ();
			Flatten(root,arr);

			for (int i = 0; i < arr.Count ; i++) {
				if (i + 1 < arr.Count) {
					arr [i].right = arr [i + 1];
					arr [i].left = null;
				}
			}

		}

		public void Flatten(TreeNode root, TreeNode prev) 
		{
			if (root == null) {
				return;
			}

			Console.WriteLine (root.val);

			Flatten (root.left,root);
			Flatten (root.right,root);

		}

		public IList<IList<int>> LevelOrder(TreeNode root) 
		{
			if (root == null) {
				return new List<IList<int>> ();
			}
			IList<IList<int>> list = new List<IList<int>> ();
			Queue<TreeNode> q = new Queue<TreeNode> ();
			q.Enqueue (root);

			List<int> tmpList = new List<int> ();
			int level = 1;
			int counting = 0;

			while (q.Count > 0) {
				var tmp = q.Dequeue ();
				tmpList.Add (tmp.val);
				level -= 1;
				Console.WriteLine (tmp.val + " ");


				if (tmp.left != null) {
					q.Enqueue (tmp.left);
					counting += 1;
				}
				if (tmp.right != null) {
					q.Enqueue (tmp.right);
					counting += 1;
				}
				if (level == 0) {
					list.Add (tmpList);
					tmpList = new List<int> ();
					Console.WriteLine ("");
					level = counting;
					counting = 0;
				}

			}

			return list;
		}


		public int MinDepth(TreeNode root) 
		{
			if (root == null) {
				return 0;
			}

			int left = MinDepth (root.left) + 1;
			int right = MinDepth (root.right) + 1;

			if (left == 1) {
				return right;
			}
			if (right == 1) {
				return left;
			} else {
				return  Math.Min(left,right);
			}

		}

		public bool IsBalanced(TreeNode root) 
		{
			if (root == null) {
				return true;
			}

			if (Math.Abs (MaxDepth (root.left) - MaxDepth (root.right)) > 1) {
				return false;
			}

			return IsBalanced (root.left) && IsBalanced (root.right);
		}

		public int MaxDepth(TreeNode root) 
		{
			if (root == null) {
				return 0;
			}

			int leftDepth = MaxDepth (root.left) + 1;
			int rightDepth = MaxDepth (root.right) + 1;

			return (int)Math.Max (leftDepth,rightDepth);
		}

		public bool IsSameTree(TreeNode p, TreeNode q) 
		{
			if (p == null && q == null) {
				return true;
			}

			if (p == null && q != null) {
				return false;
			}

			if (p != null && q == null) {
				return false;
			}

			if (p.val != q.val) {
				return false;
			}

			return IsSameTree (p.left, q.left) && IsSameTree (p.right, q.right);
		}

		public TreeNode TrimBst(TreeNode root, int min, int max)
		{
			if (root == null) {
				return null;
			}

			root.left = TrimBst(root.left, min,max);
			root.right = TrimBst(root.right, min,max);

			if (root.val <= max && root.val >= min ) {
				return root;
			}

			if (root.val < min) {
				return root.right;
			}

			if (root.val > max) {
				return root.left;
			}

			return null;
		}

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

		public void TreeLevelOrderPrint(TreeNode root)
		{
			Queue<TreeNode> q = new Queue<TreeNode>();
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
			Console.Write (root.val + " ");

			PrintBst (root.left);

			PrintBst (root.right);
		}
	
	}
}

