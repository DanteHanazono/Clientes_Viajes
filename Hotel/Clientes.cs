using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Hotel
{
    public class Hotel
    {
        private Habitacion[] habitaciones;
        private int habitacionActual;

        public Hotel()
        {
            habitaciones = new Habitacion[25];
            habitacionActual = 0;
        }

        public bool Registrar(String nombre, String cedula, String numero)
        {
            for (int i = 0; i < habitaciones.Count(); i++)
            {
                if (habitaciones[i] != null)
                {
                    if (habitaciones[i].Cedula == cedula)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Este numero de documento ya se encuentra registrado");
                        return false;
                    }
                }
            }
            habitaciones[habitacionActual] = new Habitacion(nombre, cedula, numero);
            habitacionActual++;
            Console.WriteLine(habitacionActual);
            return true;
        }
        public void ListarClientes()
        {
            for (int i = 0; i < habitaciones.Count(); i++)
            {
                if (habitaciones[i] != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Nombre----------Numero de documento--------Numero de habitacion");
                    Console.WriteLine($"{habitaciones[i].Nombre}         {habitaciones[i].Cedula}                 {habitaciones[i].Numero}");
                }
            }
        }
        public void ConsultarClientes(String id)
        {
            for (int i = 0; i < habitaciones.Count(); i++)
            {
                if (habitaciones[i] != null) {
                    if (habitaciones[i].Cedula.Equals(id))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nombre----------Numero de documento--------Numero de habitacion");
                        Console.WriteLine($"{habitaciones[i].Nombre}         {habitaciones[i].Cedula}                 {habitaciones[i].Numero}");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Este numero de documento no se encuentra registrado");
                    }
                }
                
            }
        }
    }
    public class Habitacion
    {
        public String Numero;
        public String Cedula;
        public String Nombre;

        public Habitacion(String nombre, String cedula, String numero )
        {
            Nombre = nombre;
            Cedula = cedula;
            Numero = numero;
        }
    }
}
