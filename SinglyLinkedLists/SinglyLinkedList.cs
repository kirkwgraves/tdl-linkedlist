using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {

        private SinglyLinkedListNode LastNode { get; set; }
        public SinglyLinkedListNode FirstNode { get; set; }
        public SinglyLinkedList list { get; set; }

        public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            throw new NotImplementedException();
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(string value)
        {
            throw new NotImplementedException();
        }


        public void AddLast(string value)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode(value);
            if (this.First() == null)
            {
                this.FirstNode = new_node;
            }
            else
            {
                SinglyLinkedListNode ref_node = FirstNode;
                while (!ref_node.IsLast())
                {
                    ref_node = ref_node.Next;
                }
                ref_node.Next = new_node;
            }

        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            throw new NotImplementedException();
        }

        public string ElementAt(int index)
        {
            SinglyLinkedListNode current_node = FirstNode;
            if (this.First() == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 0; i < index; i++)
            {
                current_node = current_node.Next;
            }
            return current_node.ToString();
        }

        public string First()
        {
            return FirstNode?.ToString();
        }
        
        public int IndexOf(string value)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException(); 
        }

        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {
            var ref_node = FirstNode;
            if (ref_node == null)
            {
                return null;
            }
            else
            {
                while (!ref_node.IsLast())
                {
                    ref_node = ref_node.Next;
                }
                ref_node.Next = LastNode;
                return LastNode.ToString();
            }
        }

        public void Remove(string value)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
