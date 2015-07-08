using System;

namespace LeetCode2
{
	public class ListNode {
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}

	public class ListOperations
	{
		public ListNode DeleteDuplicates(ListNode head) 
		{




		}



		public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
			int lenA = 0;
			int lenB = 0;

			var tmpA = headA;
			var tmpB = headB;

			while (tmpA != null) {
				lenA++;
				tmpA = tmpA.next;
			}

			while (tmpB != null) {
				lenB++;
				tmpB = tmpB.next;
			}

			tmpA = headA;
			tmpB = headB;

			while (lenA > lenB
			) {
				lenA--;
				tmpA = tmpA.next;
			}

			while (lenA < lenB) {
				lenB--;
				tmpB = tmpB.next;
			}

			while (tmpA != null) 
			{
				if (tmpA == tmpB) {
					return tmpA;
				} 
				tmpA = tmpA.next;
				tmpB = tmpB.next;
					
			}

			return null;
		}

	}
}

