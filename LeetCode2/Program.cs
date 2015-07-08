using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StackFromQueues q = new StackFromQueues ();
			q.Push (1);
			q.Push (2);
			q.Push (3);
			q.Push (4);
			q.Pop ();
			q.Pop ();
			q.Push (10);
			Console.WriteLine (q.Top());
		}
	}
}
