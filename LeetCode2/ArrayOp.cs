using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode2
{
	public class ArrayOp
	{
		public ArrayOp ()
		{
		}

		public IList<IList<int>> Subsets(int[] nums) 
		{
			IList<IList<int>> list = new List<IList<int>> ();
			int maxNum = (int)Math.Pow (2, nums.Length) - 1;

			List<int> tmp;

			while (maxNum >= 0) {
				string bits = Convert.ToString (maxNum, 2).PadLeft (nums.Length);
				tmp = new List<int> ();
				for (int i = 0; i < nums.Length; i++) {
					if (bits[i] == '1') {
						tmp.Add (nums [i]);
					}
				}
				maxNum -= 1;
				tmp.Sort ();
				list.Add (tmp);
			}

			return list;
		}

		public int RemoveElement(int[] nums, int val) 
		{
			int toIndex = 0;
			 
			for (int i = 0; i < nums.Length; i++) 
			{
				nums [i - toIndex] = nums [i];
				if (nums[i] == val) {
					toIndex++;
				}
			}
			return nums.Length - toIndex;
		}
	}
}

