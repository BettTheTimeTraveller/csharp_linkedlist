using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    class Node
    {
        public int data;
        public Node next;

        //public
        public Node()
        {
            Data = 0;
            Next = null;
        }

        public Node(int val)
        {
            Data = val;
        }

        public Node Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
        public int Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

    }
}
