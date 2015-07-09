using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode2
{
	public class ExcelOp
	{

		public int ConvertToNum(string s)
		{
			int end = s.Length - 1;
			int exp = 0;
			int result = 0;

			for (int i = end ; i >= 0; i--) {
				int n = (int)s [i] - 64;
				result += (int)Math.Pow (26, exp) * n;
				exp++;
			}

			return result;
		}

		public string ConvertToTitle(int n) {

			Stack<char> s = new Stack<char> ();

			while (n > 0) 
			{
				n--;
				int remainder = n % 26;
				s.Push ((char)(65 + remainder));
				n = (int) n / 26;
			}

			return string.Join("",s.ToList());
		}
	}
}

