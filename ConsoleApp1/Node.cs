namespace Lists
{
	class Node<T>
	{
		public T value;
		public Node<T> next;
		public Node<T> prev;
		public static int Count;
		public Node(T value)
		{
			this.value = value;
		}
	}
}
