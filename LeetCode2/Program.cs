using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] a = new int[]{ 1 };
			ArrayOp o = new ArrayOp ();
			int len = o.RemoveElement (a, 2);
			for (int q = 0; q < len; q++) {
				Console.WriteLine (a[q]);
			}
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
