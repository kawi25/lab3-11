using System;

namespace lab3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            Console.WriteLine("cantidad: {0}" lista.Count);
            Console.WriteLine("capacidad:{0}", lista.capacity);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                lista.Add("Dato" + i);
            }
            Console.WriteLine("cantidad: {0}" lista.Count);
            Console.WriteLine("capacidad:{0}", lista.capacity);
            Console.WriteLine();
            for (int i = 10; i < 33; i++)
            {
                lista.Add("Dato" + i);
            }
            Console.WriteLine("cantidad: {0}" lista.Count);
            Console.WriteLine("capacidad:{0}", lista.capacity);
            Console.WriteLine();
            for (int i = 10; i < 33; i++)
                foreach (string row in lista)
                {
                    Console.WriteLine(row);
                }
            Console.WriteLine("============ Eliminar rango==========");
            lista.RemoveRange(5, 4);

            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }
            lista.Insert(11 "Elemento nuevo");
            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }
            lista.Clear();
            Console.WriteLine("cantidad: {0}" lista.Count);
            Console.WriteLine("capacidad:{0}", lista.capacity);

        }
    }
}
