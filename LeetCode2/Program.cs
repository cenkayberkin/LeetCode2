using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (IsPowerOfTwo (0));
		}

		public static bool IsPowerOfTwo(int n)
		{
			if (n < 0) {
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
