using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    class LinkedList
    {
        private Node head;
        private int size;
        public LinkedList()
        {
            head = new Node();
            size = 0;
        }

        public bool isEmpty()
        {
            return head.Next == null;
        }
        public bool insert(int value)
        {
            Node newLink = new Node(value);
            newLink.Next = head;
            head = newLink;
            size++;   
            return true;
        }

        public void display()
        {
            Node refr = head;
            while(refr.Next != null)
            {
                print(refr.Data.ToString());
                refr = refr.Next;
            }
        }

        public bool pop()
        {
            if (!isEmpty())
            {
                head = head.Next;
                size += 1;
                return true;
            }
            return false;
        }

        public bool remove(int value)
        {
            if (!isEmpty())
            {
                Node refr = head;
                Node prev = null;
                while (refr.Next != null)
                {
                    if (refr.Data == value)
                    {
                        prev.Next = refr.Next;
                        size--;
                        return true;
                    }
                    prev = refr;
                    refr = refr.Next;
                }

            }
            return false;
        }

        public bool removeIndex(int index)
        {
            if (!isEmpty())
            {
                if(Size >= index + 1)
                {
                    Node refr = head;
                    Node prev = null;
                    for(int i = 0; i < Size; i++)
                    {
                        if((Size-i) == Size-(index+1))
                        {
                            prev.Next = refr.Next;
                            size--;
                            return true;
                        }
                        prev = refr;
                        refr = refr.Next;
                    }
                }
                return false;
            }
            return false;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public void print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
