using System; // Librería estándar de entrada y salida

namespace Estacionamiento
{
    class Program
    {
        // Punto de entrada principal de la aplicación
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple(); // Instanciamos nuestra lista enlazada
            int opcion = 0; // Variable para controlar el menú

            while (opcion != 6) // El ciclo se repite hasta que el usuario elija Salir (6)
            {
                // Mostramos el menú en pantalla
                Console.WriteLine("\n--- SISTEMA DE ESTACIONAMIENTO INGENIERÍA ---");
                Console.WriteLine("1. Agregar vehículo");
                Console.WriteLine("2. Buscar por placa");
                Console.WriteLine("3. Ver por año");
                Console.WriteLine("4. Ver todos registrados");
                Console.WriteLine("5. Eliminar vehículo");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                
                // Intentamos convertir la entrada a número
                if (!int.TryParse(Console.ReadLine(), out opcion)) continue; // Si falla, reinicia el ciclo

                switch (opcion) // Evaluamos la opción elegida
                {
                    case 1: // Registro de nuevo vehículo
                        Console.Write("Ingrese Placa: "); string p = Console.ReadLine(); // Lee placa
                        Console.Write("Ingrese Marca: "); string m = Console.ReadLine(); // Lee marca
                        Console.Write("Ingrese Modelo: "); string mod = Console.ReadLine(); // Lee modelo
                        Console.Write("Ingrese Año: "); int a = int.Parse(Console.ReadLine()); // Lee año
                        Console.Write("Ingrese Precio: "); double pr = double.Parse(Console.ReadLine()); // Lee precio
                        lista.InsertarFinal(p, m, mod, a, pr); // Llama al método de inserción
                        break;
                    case 2: // Búsqueda por placa
                        Console.Write("Escriba la Placa a buscar: ");
                        Nodo? n = lista.Buscar(Console.ReadLine()); // Busca el nodo
                        if (n != null) Console.WriteLine($"Encontrado: {n.Marca} {n.Modelo}, Año: {n.Año}, Precio: ${n.Precio}"); // Muestra datos
                        else Console.WriteLine("Vehículo no localizado."); // Error si no está
                        break;
                    case 3: // Filtro por año
                        Console.Write("Escriba el Año a filtrar: "); // Pide el año
                        lista.VerPorAño(int.Parse(Console.ReadLine())); // Llama al método de filtrado
                        break;
                    case 4: // Ver lista completa
                        lista.DibujarLista(); // Dibuja la estructura de la lista
                        break;
                    case 5: // Eliminación
                        Console.Write("Placa del vehículo a eliminar: ");
                        lista.Eliminar(Console.ReadLine()); // Llama al método de borrado
                        break;
                }
            }
            Console.WriteLine("Cerrando sistema..."); // Mensaje de despedida
        }
    }
}

