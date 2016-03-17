﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
            get { return this.next; }
            set {
                /* 'value' keyword refers to anything on the right side of the assign operator '=' */
                if (value == this) /* Inside of any method, I can always use 'this' to refer to the instance */
                {
                    throw new ArgumentException();
                }
                this.next = value; 
            }
        }

        private string value; /* Access using "this.value" */
        public string Value 
        {
            get { return value; }
        }

        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }                  

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }
                                                              
        public SinglyLinkedListNode(string value)
        {
            this.value = value;
            // Used by the visualizer:
            allNodes.Add(this);
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            SinglyLinkedListNode compared_node = obj as SinglyLinkedListNode;
            return compared_node == null? 1 : this.value.CompareTo(compared_node.Value);    
        }

        public bool IsLast()
        {
            return (this.next == null);
        }

        public override string ToString()
        {
            return this.value;
        }

        public override bool Equals(Object obj)
        {
                var temp = obj as SinglyLinkedListNode;
                return (this.value == temp?.Value);
        }

    }
}
