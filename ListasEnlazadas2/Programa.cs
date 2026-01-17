using System; // Importación de librerías del sistema

namespace Estacionamiento // Espacio de nombres unificado
{
    class Program // Clase principal del programa
    {
        static void Main(string[] args) // Punto de entrada del programa
        {
            ListaSimple listaPrincipal = new ListaSimple(); // Creamos la lista para los datos iniciales
            ListaSimple listaMenores = new ListaSimple(); // Creamos la lista para valores <= promedio
            ListaSimple listaMayores = new ListaSimple(); // Creamos la lista para valores > promedio

            Console.Write("Ingrese la cantidad de datos a cargar (N): "); // Pedimos la cantidad de datos
            int n = int.Parse(Console.ReadLine()); // Convertimos la entrada a un entero N

            for (int i = 0; i < n; i++) // Ciclo para cargar N cantidad de datos
            {
                Console.Write("Ingrese el dato real #" + (i + 1) + ": "); // Solicitamos el dato al usuario
                double valor = double.Parse(Console.ReadLine()); // Leemos el dato y lo convertimos a double (real)
                listaPrincipal.InsertarFinal(valor); // Cargamos el dato en la lista principal
            }

            double promedio = listaPrincipal.CalcularPromedio(); // Calculamos el promedio de la lista principal

            Nodo? actual = listaPrincipal.head; // Empezamos a recorrer la lista principal para clasificar
            while (actual != null) // Mientras el nodo no sea nulo
            {
                if (actual.Valor <= promedio) // Si el dato es menor o igual al promedio
                {
                    listaMenores.InsertarFinal(actual.Valor); // Lo cargamos en la segunda lista
                }
                else // Caso contrario (si es mayor al promedio)
                {
                    listaMayores.InsertarFinal(actual.Valor); // Lo cargamos en la tercera lista
                }
                actual = actual.Next; // Pasamos al siguiente nodo de la principal
            }

            Console.WriteLine("\na. Datos en la lista principal:"); // Etiqueta para el requerimiento A
            listaPrincipal.MostrarLista(); // Mostramos la lista principal dibujada

            Console.WriteLine("\nb. El promedio es: " + promedio); // Etiqueta para el requerimiento B con el valor

            Console.WriteLine("\nc. Datos menores o iguales al promedio:"); // Etiqueta para el requerimiento C
            listaMenores.MostrarLista(); // Mostramos la lista de menores o iguales

            Console.WriteLine("\nd. Datos mayores al promedio:"); // Etiqueta para el requerimiento D
            listaMayores.MostrarLista(); // Mostramos la lista de mayores

            Console.WriteLine("\nProceso finalizado en este 2026."); // Mensaje de cierre del programa
            Console.ReadKey(); // Esperamos una tecla para cerrar la consola
        }
    }
}
