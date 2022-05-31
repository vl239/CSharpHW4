using System;
namespace CSharpHW4
{
	public class MyStack<T>
	{
        List<T> MyList = new List<T>();

        public int Count()
        {
            return MyList.Count();
        }

        public T Pop()
        {
            T popItem = MyList[0];
            MyList.RemoveAt(0);
            return popItem;
        }

        public void Push(T element)
        {
            MyList.Insert(0, element);
        }

        public void Add(T element)
        {
            MyList.Add(element);
        }

        public T Remove(int index)
        {
            T item = MyList[index];
            MyList.Remove(item);
            return item;
        }

        public bool Contains(T element)
        {
            return MyList.Contains(element);
        }

        public void Clear()
        {
            MyList.Clear();
        }

        public void InsertAt(T element, int index)
        {
            MyList.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            MyList.RemoveAt(index);
        }

        public T Find(int index)
        {
            return MyList[index];
        }

        
	}
}

