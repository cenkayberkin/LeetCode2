using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ListNode n1 = new ListNode (1);
			ListNode n2 = new ListNode (2);
			ListNode n3 = new ListNode (3);
			ListNode n4 = new ListNode (4);
			ListNode n5 = new ListNode (5);
			ListNode n6 = new ListNode (5);
			ListNode n7 = new ListNode (5);

			n1.next = n2;
			n2.next = n3;
			n3.next = n4;
			n4.next = n5;
			n5.next = n6;
			n6.next = n7;

			ListOperations o = new ListOperations ();
			var head = o.DeleteDuplicates (n1);

			var tmp = head;

			while (tmp != null) {
				Console.WriteLine (tmp.val);
				tmp = tmp.next;
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
