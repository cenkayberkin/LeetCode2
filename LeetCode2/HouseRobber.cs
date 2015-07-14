using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode2
{
	
	public class HouseRobber
	{
		public int rob(int[] num) 
		{
			if (num.Length == 0 || num == null) {
				return 0;
			}

			int[] list = new int[num.Length + 1];
			list [0] = 0;
			list [1] = num [0];

			for (int i = 2; i < num.Length  + 1; i++) {
				int a = num [i - 1] + list [i - 2];
				int b = list [i - 1];
				list [i] = Math.Max (a,b);
			}

			return list[num.Length];
		}

	}
}

