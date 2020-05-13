using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel
{
    public class Viajes
    {
        private Destino[] destinos;
        private int viajeActual;

        public Viajes()
        {
            destinos = new Destino[25];
            viajeActual = 0;
        }
        public bool RegistrarDestino(String dest, String pre)
        {
            for (int i = 0; i < destinos.Count(); i++)
            {
                if (destinos[i] != null)
                {
                    if (destinos[i].Dest == dest) return false;
                }
            }
            destinos[viajeActual] = new Destino(dest, pre);
            viajeActual++;
            return true;
        }

        public void ListarDestinos()
        {
            for (int i = 0; i < destinos.Count(); i++)
            {
                if (destinos[i] != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Destino--------Precio");
                    Console.WriteLine($"{destinos[i].Dest}         {destinos[i].Pre}");
                }
            }
        }
        public void EditarPrecio(String destiny)
        {
            for (int i = 0; i < destinos.Count(); i++)
            {
                if (destinos[i] != null)
                {
                    if (destinos[i].Dest.Equals(destiny))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Digite el valor por el cual desea modificar");
                        string price = Console.ReadLine();
                        destinos[i].Pre = price;
                        Console.WriteLine("");
                        Console.WriteLine("Destino--------Precio");
                        Console.WriteLine($"{destinos[i].Dest}         {destinos[i].Pre}");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Este destino no se encuentra registrado");
                    }
                }

            }
        }
        public class Destino
        {
            public String Dest;
            public String Pre;

            public Destino(String dest, String pre)
            {
                Dest = dest;
                Pre = pre;
            }
        }
    }
}
