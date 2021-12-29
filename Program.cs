using System;
     
public class LinkedList
{
 
    // Head of list
    public Node head;
 
    // Linked list Node
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
 
    void deleteNode(int key)
    {
 
  
        Node first = head;
 
      
        Node second = head;
        for (int i = 0; i < key; i++)
        {
 
            if (second.next == null)
            {
 
               
                if (i == key - 1)
                    head = head.next;
                return;
            }
            second = second.next;
        }
 
      
        while (second.next != null)
        {
            first = first.next;
            second = second.next;
        }
 
     
        first.next = first.next.next;
    }
 
   
    public void push(int new_data)
    {
        Node new_node = new Node(new_data);
        new_node.next = head;
        head = new_node;
    }
 
    // Function to print the linked list
    public void printList()
    {
        Node tnode = head;
        while (tnode != null)
        {
            Console.Write(tnode.data + " ");
            tnode = tnode.next;
        }
    }
 
  
    public static void Main(String[] args)
    {
        LinkedList llist = new LinkedList();
 
        llist.push(7);
        llist.push(1);
        llist.push(3);
        llist.push(2);
 
        Console.WriteLine("\nCreated Linked list is:");
        llist.printList();
 
        int N = 1;
        llist.deleteNode(N);
 
        Console.WriteLine("\nLinked List after Deletion is:");
        llist.printList();
       Console.ReadLine();
    }
}