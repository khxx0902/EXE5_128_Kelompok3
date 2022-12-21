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
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Memasukkan Data");
                    Console.WriteLine("2. Menghapus Data");
                    Console.WriteLine("3. Menampilkan Data");
                    Console.WriteLine("4. Keluar");
                    Console.WriteLine("\nMasukkan Pilihan Anda (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                q.insert();
                                break;
                            }
                        case '2':
                            {
                                q.delete();
                                break;
                            }
                        case '3':
                            {
                                q.display();
                                break;
                            }
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Opsi Tidak Valid!!");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Periksa nilai yang dimasukkan");
                }
            }
        }
    }
}
