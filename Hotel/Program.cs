using System;
using System.Runtime.CompilerServices;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
			string linea, name, id, room, destiny, price;
			int opcion;
			Hotel reg = new Hotel();
			Viajes via = new Viajes();
			do
			{
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("MENU DE OPCIONES");
				Console.WriteLine("1. Registrar clientes");
				Console.WriteLine("2. Registrar viajes");
				Console.WriteLine("3. Imprimir directorio clientes");
				Console.WriteLine("4. Imprimir listado viajes");
				Console.WriteLine("5. Consulta de un cliente");
				Console.WriteLine("6. Modificar valor de un viaje");
				Console.WriteLine("7. SALIR");
				Console.WriteLine("");
				linea = Console.ReadLine();
				opcion = int.Parse(linea);
				switch (opcion)
				{
					case 1:
						Console.WriteLine("");
						Console.WriteLine("Digite nombre del cliente");
						name = Console.ReadLine();
						Console.WriteLine("");
						Console.WriteLine("Digite numero de documento del cliente");
						id = Console.ReadLine();
						Console.WriteLine("");
						Console.WriteLine("Digite numero de la habitacion donde se hospedara el cliente");
						room = Console.ReadLine();
						reg.Registrar(name, id, room);
						break;
					case 2:
						Console.WriteLine("");
						Console.WriteLine("Digite el destino");
						destiny = Console.ReadLine();
						Console.WriteLine("");
						Console.WriteLine("Digite el valor");
						price = Console.ReadLine();
						via.RegistrarDestino(destiny, price);
						break;
					case 3:
						reg.ListarClientes();
						break;
					case 4:
						via.ListarDestinos();
						break;
					case 5:
						Console.WriteLine("");
						Console.WriteLine("Digite el numero de cedula que desea consultar");
						id = Console.ReadLine();
						reg.ConsultarClientes(id);
						break;
					case 6:
						Console.WriteLine("");
						Console.WriteLine("Digite el destino para modificar el precio");
						destiny = Console.ReadLine();
						via.EditarPrecio(destiny);
						break;
				}
			} while (opcion != 7);
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("Saliendo del programa");
		}
    }
}
