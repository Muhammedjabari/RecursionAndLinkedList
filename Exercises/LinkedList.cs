namespace Exercises
{
    public class ListNode
    {
        public string Data;
        public ListNode Next;

        public ListNode(string data, ListNode next = null) {
            this.Data = data;
            this.Next = null;
        }
    }

    public class LinkedList {
        public ListNode Head;

        public LinkedList() {
            Head = null;
        }

        public void AddToEnd(string newData) {
            ListNode newNode = new ListNode(newData, null);
            
            if (Head == null) {
                Head = newNode;
                return;
            } 
            
            ListNode current = Head;

            while (current.Next != null) {
                current = current.Next;
            }

                current.Next = newNode;
        }
        
        public ListNode GetNodeAt(int index) {
            int count = 0;

            if (index < 0) {
                return null;
            }
            
            ListNode current = Head;
            while (count < index) {
                if (current.Next != null) {
                    current = current.Next;
                } else {
                    return null;
                }
                count++;
            }

            return current;
        }

        public bool Find(string searchTerm) {
            ListNode current = Head;

            while (current != null) {
                if (current.Data == searchTerm) {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Returns the number of nodes in the Linked List
        /// </summary>
        /// <returns>int: count</returns>
        public int Count()
        {
            int count = 0;
            ListNode current = Head;
            while (current != null)
            {
                current = current.Next;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Adds a node to the start of the list.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>success: true</returns>
        public bool AddToStart(string data)
        {
            ListNode newNode = new ListNode(data);
            if (Head == null)
            {
                Head = newNode;
                return false;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                return true;
            }

        }
        /// <summary>
        /// add new node at index.  If index specified is greater than the size of the current list,
        /// adds nodes with null data in between.  Negative index will return false.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool AddNodeAt(string data, int index) {
            ListNode newNode = new ListNode(data);

            //if asked to add to -ve index (i.e. doesnt exist) 'tell them to bugger off.
            if (index <= 0)
            {
                return false;
            }

            // make a copy of the head (start of list)
            ListNode current = Head;

            // set up to track the node before the current
            

            int i = 0;
            // find the node ate the needed index
            while (i < index - 1)
            {
                if (current.Next == null)
                {
                    ListNode nullnode = new ListNode(null, null);
                    current.Next = nullnode;
                }
                current = current.Next;
                i++;
            }

            newNode.Next = current.Next;
            current.Next = newNode;

            return true;
        }

        /// <summary>
        /// Delete node at index.  return false if node does not exist
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteNodeAt(int index) {
            if (Head == null)
            {
                return false;
            }

            ListNode current = Head;

            if (index == 0)
            {
                Head = current.Next;
                return true;
            }

            for (int i = 0; current != null && i < index - 1; i++)
            {
                current = current.Next;
            }

            if (current == null || current.Next == null)
            {
                return false;
            }

            ListNode next = current.Next.Next;
            current.Next = next;
            return true;
        }
    }
}