using System;
namespace Lists
{
	class MyList<T>
	{
		public Node<T> prev;
		public Node<T> head;
		public Node<T> tail;
		public Node<T> list;
		public int count;
		public void PushBack(Node<T> newNode)
		{
			Node<T>.Count++;
			if (list != null)
			{
				GetLast().next = newNode;
				GetLast().prev = prev;
				tail = GetLast();
				prev = GetLast();
				return;
			}
			list = newNode;
			head = list;
			prev = list;
			tail = list;
		}
		public void PushFront(Node<T> NewNode)
		{
			Node<T> node = NewNode;
			node.next = head;
			head.prev = node;
			head = node;
		}
		public Node<T> GetLast()
		{
			Node<T> current = list;
			while (current.next != null)
			{
				current = current.next;
				count++;
			}
			return current;
		}
		public void Print()
		{
			Node<T> Head = head;
			while (Head != null)
			{
				Console.WriteLine(Head.value);
				Head = Head.next;
			}
			Console.WriteLine();
		}
		public void PrintReverse()
		{
			Node<T> Tail = tail;
			while (Tail != null)
			{
				Console.WriteLine(Tail.value);
				Tail = Tail.prev;
			}
			Console.WriteLine();
		}
		public void Insert(int index, T value)
		{
			var node = head;
			var id = 0;
			while (node != null)
			{
				if (id++ == index)
				{
					var prev = node.prev;
					node.prev = new Node<T>(value);
					var newNode = node.prev;
					newNode.next = node;
					newNode.prev = prev;
					if (prev != null)
						prev.next = newNode;
					++count;
					return;
				}
				node = node.next;
			}
		}
		public void InsertBefore(int index, T value)
        {
			var node = head;
			var id = -1;
			while (node != null)
			{
				if (id++ == index)
				{
					var prev = node.prev;
					node.prev = new Node<T>(value);
					var newNode = node.prev;
					newNode.next = node;
					newNode.prev = prev;
					if (prev != null)
						prev.next = newNode;
					++count;
					return;
				}
				node = node.next;
			}
		}
		public void InsertAfter(int index, T value)
        {
			var node = head;
			int id = 1;
			while (node != null)
			{
				if (id++ == index)
				{
					var prev = node.prev;
					node.prev = new Node<T>(value);
					var newNode = node.prev;
					newNode.next = node;
					newNode.prev = prev;
					if (prev != null)
						prev.next = newNode;
					++count;
					return;
				}
				node = node.next;
			}
		}
		public Node<T> FindEl(int index)
		{
			var current = head;
			int i = 0;
			while (current != null)
			{
				if (i == index) 
					return current;
				i++;
				current = current.next;
			}
			return null;
		}
		public Node<T> Remove(int index)
        {
			var el = FindEl(index);
			if (el.prev != null)
				el.prev.next = el.next;
			else
				head = el.next;
			return el;
		}		
		public Node<T> PopFront()
        {
			var res = Remove(0);
			return res;
		}
		public Node<T> PopBack()
        {
			var res = GetLast().prev.next = null;
			return res;
		}
	}
}