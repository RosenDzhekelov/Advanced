using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public ListNode<T> Head { get; set; }
        public int Count { get; set; }
        public ListNode<T> Tail { get; set; }
        public DoublyLinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }
        public DoublyLinkedList(T value)
            : this()
        {
            ListNode<T> newNode = new ListNode<T>()
            {
                Value = value,
                Next = null,
                Previous = null
            };
            Head = Tail = newNode;
            Count++;
        }
        public DoublyLinkedList(IEnumerable<T> list)
            : this(list.First())
        {
            bool isFirst = true;
            foreach (var item in list)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    ListNode<T> newNode = new ListNode<T>()
                    {
                        Previous = Tail,
                        Value = item,
                        Next = null
                    };
                    Tail.Next = newNode;
                    Tail = newNode;
                }
                Count++;
            }
        }
        public void AddFirst(T value)
        {
            ListNode<T> node = new ListNode<T>()
            {
                Value = value
            };
            if (Count == 0)
            {
                Head = Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }
            Count++;
        }
        public void AddLast(T value)
        {
            ListNode<T> node = new ListNode<T>()
            {
                Value = value
            };
            if (Count == 0)
            {
                Head = Tail = node;
            }
            else
            {
                node.Previous = Tail;
                Tail.Next = node;
                Tail = node;
            }
            Count++;
        }
        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            T result = Head.Value;

            ListNode<T> second = Head.Next;
            if (second == null)
            {
                Tail = null;
            }
            else
            {
                second.Previous = null;
            }
            Head = second;
            Count--;
            return result;
        }
        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            T result = Tail.Value;

            ListNode<T> secondToLast = Tail.Previous;
            if (secondToLast == null)
            {
                Head = null;
            }
            else
            {
                secondToLast.Next = null;
            }

            Tail = secondToLast;
            Count--;
            return result;

        }
        public void ForEach(Action<T> action)
        {
            ListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }

        }
        public T[] ToArray()
        {
            T[] result = new T[Count];
            int index = 0;
            ListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                result[index] = currentNode.Value;
                index++;
                currentNode = currentNode.Next;
            }
            return result;
        }
    }
}
