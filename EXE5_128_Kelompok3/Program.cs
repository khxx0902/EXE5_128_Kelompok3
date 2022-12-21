using System;

namespace Exe3_128_Kelompok3
{
    class Node
    {
        public string name;
        public Node next;

    }
    class Queue
    {
        Node Khaidar, Royani;

        public Queue()
        {
            Khaidar = null;
            Royani = null;
        }
        public void insert()
        {
            string nm;
            Node newNode = new Node();
            Console.WriteLine("Masukkan Data: ");
            nm = Console.ReadLine();
            newNode.name = nm;
            newNode.next = null;
            if(Khaidar == null)
            {
                Khaidar = newNode;
                Royani = newNode;
            }
            Royani.next = newNode;
            Royani = newNode;
        }
        public void delete()
        {
            if (Khaidar == null)
            {
                Console.WriteLine("Queue Kosong");
                return;
            }
            Khaidar = Khaidar.next;
            if (Khaidar == null)
                Royani = null;
        }
        public void display()
        {
            if (Khaidar == null)
            {
                Console.WriteLine("Queue Kosong");
                return;
            }
        }
    }
}
