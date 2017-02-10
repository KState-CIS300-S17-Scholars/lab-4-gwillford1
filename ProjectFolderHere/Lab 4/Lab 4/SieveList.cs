using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class SieveList: IEnumerable<int>
    {
        private Node _head;
        private Node _tail;
        private int _size;

        public void BuildList(int bound)
        {
            _size = 0;

            for (int i = 2; i <= bound; i++)
            {
                Add(i);
                
            }

        }

        public void Add(int val)
        {
            Node newNode = new Lab_4.SieveList.Node(val);

            if (_size == 0)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }

            _size++;
        }

        public bool FindPrimes()
        {
            Node cur = _head;
            if (cur != null)
            {
                for (int i =2; i < Math.Sqrt(_tail.Data); i++)
                {
                    Node temp = cur.Next;
                    try
                    {
                        while (temp != null)
                        {

                            if (temp.Next.Data % i == 0)
                            {
                                temp.Next = temp.Next.Next;
                            }
                            temp = temp.Next;

                        }
                        cur = cur.Next;
                    }
                    catch(Exception e)
                    {

                    }
                }
                return true;
            }
            else return false;

        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SieveEnumerator(_head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SieveEnumerator(_head);
        }

        private class Node
        {
            private int _data;
            private Node _next;

            public Node(int d)
            {
                _data = d;
            }

            public int Data
            {
                get
                {
                    return _data;
                }
                set
                {
                    _data = value;
                }
            }

            public Node Next
            {
                get
                {
                    return _next;
                }
                set
                {
                    _next = value;
                }
            }

        }

        private class SieveEnumerator : IEnumerator<int>
        {
            Node current;

            public SieveEnumerator(Node head)
            {
                Node dummy = new Lab_4.SieveList.Node(1);
                dummy.Next = head;

                current = dummy;
                
            }

            public int Current
            {
                get
                {
                   
                    return current.Data;
                    
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return current.Data;
                }
            }

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                if (current.Next == null)
                    return false;
                else
                {
                    current = current.Next;
                    return true;
                }
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
