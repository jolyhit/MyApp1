using System;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new();
            Console.WriteLine("Вывод листа: ");
            list.PushBack(new Node<int>(10));
            list.PushFront(new Node<int>(56));
            list.PushFront(new Node<int>(44));
            list.PushBack(new Node<int>(12));
            list.PushFront(new Node<int>(14));
            list.Print();
            Console.WriteLine("Вывод листа в обратном порядке: ");
            list.PrintReverse();
            Console.WriteLine("Вставка нового элемента по указанному индексу:");
            list.Insert(1, 111);
            list.Print();
            Console.WriteLine("Вставка нового элемента после указанного индекса:");
            list.InsertBefore(2, 222);
            list.Print();
            Console.WriteLine("Вставка нового элемента перед указанным индексом:");
            list.InsertAfter(5, 333);
            list.Print();
            Console.WriteLine("Удаление элемента по указанному индексу:");
            list.Remove(1);
            list.Print();
            Console.WriteLine("Удаление первого и последнего элемента:");
            list.PopFront();
            list.PopBack();
            list.Print();            
            Console.ReadKey();
        }
    }
}