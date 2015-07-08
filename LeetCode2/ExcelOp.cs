using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode2
{
	public class ExcelOp
	{
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

