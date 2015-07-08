using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode2
{
	public class StackFromQueues
	{
		Queue<int> q1 ;
		Queue<int> q2 ;
		int count;

		public StackFromQueues()
		{
			count = 0;
			q1 = new Queue<int> ();
			q2 = new Queue<int> ();
		}

		public void Push(int x) 
		{
			count++;
			if (q1.Count == 0) {
				q1.Enqueue (x);
				while (q2.Count > 0) {
					q1.Enqueue (q2.Dequeue ());
				}
			} else {
				q2.Enqueue (x);
				while (q1.Count > 0) {
					q2.Enqueue (q1.Dequeue ());
				}
			}
		}

		// Removes the element on top of the stack.
		public void Pop() {
			if (!Empty ()) {
				count--;
				if (q1.Count == 0) {
					q2.Dequeue ();
				} else {
					q1.Dequeue ();
				}
			}
		}

		// Get the top element.
		public int Top() {
			if (q1.Count == 0) {
				return q2.Peek ();
			} else {
				
				return q1.Peek ();
			}
		}

		// Return whether the stack is empty.
		public bool Empty() {
			return count == 0;
		}
	}
}

