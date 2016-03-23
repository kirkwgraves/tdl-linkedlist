﻿using System;
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

        public override string ToString()
        {
            if (this.First() == null)
            {
                // If list is empty, return string representation of empty array
                return "{ }";
            }
            else
            {
                var list_as_array = this.ToArray();
                var strBuilder = new StringBuilder();
                strBuilder.Append("{ ");
                int length = list_as_array.Length;
                for (int i = 0; i <= length - 1; i++)
                {
                    if (i == length - 1)
                    {
                        strBuilder.Append("\"" + list_as_array[i] + "\"");
                    }
                    else
                    {
                        strBuilder.Append("\"" + list_as_array[i] + "\", ");
                    }
                }
                
                strBuilder.Append(" }");
                return strBuilder.ToString();
            }
            
        }
        

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            if (values.Length == 0)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < values.Length; i++)
            { 
                AddLast(values[i].ToString());
            }
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            int location = IndexOf(existingValue);
            if (location == -1)
            {
                throw new ArgumentException();
            }
            var ref_list = new SinglyLinkedList();
            for (int i = 0; i < Count(); i++)
            {
                ref_list.AddLast(ElementAt(i));
                if (location == i) // Find the correct position to add the new node value
                {
                    ref_list.AddLast(value);
                }
            }
            FirstNode = new SinglyLinkedListNode(ref_list.First()); // 
            for (int j = 1; j < ref_list.Count(); j++)
            {
                this.AddLast(ref_list.ElementAt(j));
            }
        }

        public void AddFirst(string value)
        {
            throw new NotImplementedException();
        }


        public void AddLast(string value)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode(value);
            if (First() == null)
            {
                FirstNode = new_node;
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
            if (this.First() == null)
            {
                return 0;
            }
            else
            {
                int list_length = 1;
                var ref_node = FirstNode;
                // Complexity at this point is O(n)
                // What would O(1) implementation look like?
                while (!ref_node.IsLast())
                {
                    ref_node = ref_node.Next;
                    list_length++;
                }
                return list_length;
            }
        }

        public string ElementAt(int index)
        {
            SinglyLinkedListNode desired_node = FirstNode;
            if (this.First() == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 0; i < index; i++)
            {
                desired_node = desired_node.Next;
            }
            return desired_node.ToString();
        }

        public string First()
        {
            return FirstNode?.ToString();
        }
        
        public int IndexOf(string value)
        {
            int counter = 0;
            var ref_node = FirstNode;
            if (ref_node == null)
            {
                return -1;
            }
            while (!(ref_node.Value == value))
            {
                if (ref_node.Next == null)
                {
                    return -1;
                }
                ref_node = ref_node.Next;
                counter++;
            }
            return counter;
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
            LastNode = FirstNode;
            if (LastNode == null)
            {
                return null;
            }
            else
            {
                while (!LastNode.IsLast())
                {
                    LastNode = LastNode.Next;
                }
                return LastNode.ToString();
            }
        }

        public string ToString(SinglyLinkedListNode[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i].ToString();
            }
            return values.ToString();
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
            string[] empty_array = new string[] { };
            string[] new_array = new string[this.Count()];

            if (this.First() == null)
            {
                return empty_array;
            }
            else
            {
                for (int i = 0; i < this.Count(); i++)
                {
                    new_array[i] = this.ElementAt(i);
                }
                return new_array;
            }
        }
    }
}
