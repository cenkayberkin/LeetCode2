using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TreeNode n1 = new TreeNode (1);
			TreeNode n2 = new TreeNode (2);
			TreeNode n3 = new TreeNode (3);
			TreeNode n4 = new TreeNode (4);
			TreeNode n5 = new TreeNode (5);
			TreeNode n6 = new TreeNode (6);

			n1.left = n2;
			n1.right = n5;

			n2.left = n3;
			n2.right = n4;

			n5.right = n6;

			TreeOp o = new TreeOp ();
			o.Flatten (n1);
//			Console.WriteLine ("");
//			var e = o.LevelOrder (n1);
//			Console.WriteLine ("");

//			o.PrintBst (n1);
		}

		public static bool IsPalindrome(int n)
		{
			string text = n.ToString ();
			int len = text.Length - 1;
			for (int i = 0; i < text.Length / 2; i++) {
				if (text[i] != text[len - i]) {
					return false;
				}
			}
			return true;
		}

		public static bool IsPowerOfTwo(int n)
		{
			if (n <= 0) {	
				return false;
			}
			if (((n - 1) & n) == 0) {
				return true;
			}else{
				return false;
			}
		}
	}
}
