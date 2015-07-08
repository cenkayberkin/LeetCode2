using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode2
{
	public class QueueFromStack
	{
		Stack<int> s1;
		Stack<int> s2;
		int count;

		public QueueFromStack ()
		{
			s1 = new Stack<int> ();
			s2 = new Stack<int> ();
			count = 0;
		}

		public void Push(int x) {
			count++;
			while (s2.Count > 0) {
				s1.Push (s2.Pop ());
			}
			s2.Push (x);
			while (s1.Count > 0) {
				s2.Push (s1.Pop ());
			}
		}

		// Removes the element from front of queue.
		public void Pop() {
			if (count >0) {
				count--;
				s2.Pop ();	
			}
		}

		// Get the front element.
		public int Peek() {
			return s2.Peek ();
		}

		// Return whether the queue is empty.
		public bool Empty() {
			return count == 0;
		}
	}
}

