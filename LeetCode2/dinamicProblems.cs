using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode2
{
	public class dinamicProblems
	{
		Dictionary<int,int> dic = new Dictionary<int, int>();
		public int ClimbStairs(int n) 
		{
			int[] a = new int[]{ 0 };
			return ClimbStairs2 (n, a);
		}

		public int ClimbStairs2(int n,int[] arr) 
		{
			if (n == 0) {
				arr [0] += 1;
				return arr [0];
			}

			var candidates = GenerateCandidates (n);
			int total = 0;
			foreach (var item in candidates) {
				if (n > 0) {
					int newN = n - item;
					total = ClimbStairs2 (newN, arr);
				}
			}

			return total;
		}


		public int ClimbStairs3(int h)
		{
			if (h == 0) {
				return 1;
			}
			if (h == 1) {
				return 1;
			}
			int prev1 = 0;
			int prev2 = 0;

			if (dic.ContainsKey (h - 1)) {
				prev1 = dic [h - 1];
			} else {
				prev1 = ClimbStairs3 (h - 1);
				dic [h - 1] = prev1;
			}

			if (dic.ContainsKey (h - 2)) {
				prev2 = dic [h - 2];
			} else {
				prev2 = ClimbStairs3 (h - 2);
				dic [h - 2] = prev2;
			}

			return prev1 + prev2; 
		}


		public void ClimbStairs(int n,int[] totalNum) 
		{
			if (n == 0) {
				totalNum [0] += 1;
				return;
			} 
				
			var candidates = GenerateCandidates (n);
			foreach (var item in candidates) {
				if (n > 0) {
					int newN = n - item;

					ClimbStairs (newN, totalNum);	
				}
			}
		}

		public List<int> GenerateCandidates(int n)
		{
			if (n >= 2) {
				return new List<int> (){ 1, 2 };
			} 
			else {
				return new List<int> (){ 1 };
			}
		
		}

	}
}

