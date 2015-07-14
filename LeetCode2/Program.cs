﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			TreeNode n1 = new TreeNode (10);
//			TreeNode n2 = new TreeNode (5);
//			TreeNode n3 = new TreeNode (8);
//			TreeNode n4 = new TreeNode (1);
//			TreeNode n5 = new TreeNode (15);
//			TreeNode n6 = new TreeNode (13);
//			TreeNode n7 = new TreeNode (20);
//			TreeNode n8 = new TreeNode (35);
//
//			n1.left = n2;
//			n1.right = n5;
//			n2.left = n4;
//			n2.right = n3;
//			n5.left = n6;
//			n5.right = n7;
//
//			n7.right = n8;
//
//
//			TreeNode n11 = new TreeNode (10);
//			TreeNode n21 = new TreeNode (5);
//			TreeNode n31 = new TreeNode (8);
//			TreeNode n41 = new TreeNode (1);
//			TreeNode n51 = new TreeNode (15);
//			TreeNode n61 = new TreeNode (13);
//			TreeNode n71 = new TreeNode (20);

//			int[] arr = new int[]{ 1};
//
//			ArrayOp o = new ArrayOp ();
//			Console.WriteLine (o.SearchInsert (arr, 0));
//			Console.WriteLine (o.searchInsert(arr,0));

//			dinamicProblems d = new dinamicProblems ();
//			Console.WriteLine (d.ClimbStairs (6));
//			Console.WriteLine (d.ClimbStairs3 (35));
			int[] houses = new int[]{};
			HouseRobber r = new HouseRobber ();
			Console.WriteLine (r.rob (houses));
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
