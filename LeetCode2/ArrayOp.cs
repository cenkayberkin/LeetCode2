using System;

namespace LeetCode2
{
	public class ArrayOp
	{
		public ArrayOp ()
		{
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

