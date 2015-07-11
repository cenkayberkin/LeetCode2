﻿using System;
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

		public int SearchInsert(int[] nums, int target) 
		{
			return SearchInsertAux (nums, target, 0, nums.Length);
		}

		public int SearchInsertAux(int[] nums, int target,int lo, int hi)
		{
			if (lo > hi) {
				return -1;
			}

			int mid = (hi + lo) / 2; 

			if (nums[mid] == target) {
				return mid;
			}
			if (nums [mid] > target) {
				if (mid == 0) {
					return 0;	
				} else if (nums [mid - 1] < target) {
					return mid;
				}else if ( nums [mid - 1] == target){
					return mid -1;
				} else {
					return SearchInsertAux (nums,target,0,mid - 1);
				}
			} else {
				if (mid == nums.Length - 1) {
					return nums.Length;	
				} else if (nums [mid + 1] >= target) {
					return mid + 1;
				} else {
					return SearchInsertAux (nums,target,mid+1,nums.Length);
				}
			}

		}

		public bool SearchMatrix(int[,] matrix, int target) 
		{

			int row = matrix.GetLength (0);
			int col = matrix.GetLength (1) ;

			bool foundSmallerRow = false;

			for (int i = 0; i < row; i++) {
				if (matrix [i, col - 1] >= target) {
					row = i;
					foundSmallerRow = true;
					break;
				}
			}

			if (!foundSmallerRow) {
				return false;
			}

			int[] arr = new int[col];

			for (int i = 0; i < col; i++) {
				arr [i] = matrix [row, i];	
			}

			return FindIt(arr,0,col,target) ;
		}

		public bool FindIt(int[] arr, int min, int max, int target)
		{
			if (min > max) {
				return false;
			}

			int mid = (min + max) / 2;
			if (arr[mid] == target) {
				return true;
			}

			if (arr [mid] > target) {
				return FindIt (arr, min, mid - 1, target);

			} else {
				return FindIt (arr, mid + 1, max, target);
			}	

			return true;
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

