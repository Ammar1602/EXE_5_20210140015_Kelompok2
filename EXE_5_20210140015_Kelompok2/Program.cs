using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EXE_5_20210140015_Kelompok2
{
    class Queues
    {
        int Ammar, Syuhada, max = 10;
        int[] queue_array = new int[10];
        public Queues()
        {
            Ammar = -1;
            Syuhada = -1;
        }

        public void insert(int element)
        {
            if (Ammar == -1)
            {
                Ammar = 0;
                Syuhada = 0;
            }
            else
            {
                if (Syuhada == max - 1)
                    Syuhada = 0;
                else
                    Syuhada = Syuhada + 1;
            }
            queue_array[Syuhada] = element;
        }
        public void delete()
        {
            if (Ammar == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queueis:" + queue_array[Ammar] + "\n");
            if (Ammar == Syuhada)
            {
                Ammar = -1;
                Syuhada = -1;
            }
            else
            {
                if (Ammar == max - 1)
                    Ammar = 0;
                else
                    Ammar = Ammar + 1;
            }
        }
        public void display()
        {
            int Ammar_position = Ammar;
            int Syuhada_position = Syuhada;
            if (Ammar == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElement is the queue are...\n");
            if (Ammar_position <= Syuhada_position)
            {
                while (Ammar_position <= Syuhada_position)
                {
                    Console.Write(queue_array[Ammar_position] + " ");
                    Ammar_position++;
                }
                Console.WriteLine();
            }
            else
            {
                while (Ammar_position <= max - 1)
                {
                    Console.Write(queue_array[Ammar_position] + " ");
                    Ammar_position++;
                }
                Ammar_position = 0;
                while (Ammar_position <= Syuhada_position)
                {
                    Console.Write(queue_array[Ammar_position] + " ");
                    Ammar_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("1. Implement Inssert Option");
                    Console.WriteLine("2. ");
                }
            }
        }
    }
}
