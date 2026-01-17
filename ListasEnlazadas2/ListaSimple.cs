using System; // Importación de funciones básicas del sistema

namespace Estacionamiento // Espacio de nombres unificado
{
    public class ListaSimple // Clase que gestiona la lista enlazada simple
    {
        public Nodo? head; // Nodo inicial de la lista (Cabeza)

        public ListaSimple() // Constructor de la lista
        {
            head = null; // Al crear la lista, la cabeza apunta a nulo (vacía)
        }

        public void InsertarFinal(double dato) // Método para insertar un nodo al final
        {
            Nodo nuevoNodo = new Nodo(dato); // 1. Se crea un nodo con el dato a almacenar
            if (head == null) // 2. En caso de que head apunta a null
            {
                head = nuevoNodo; // Significa que no hay elementos y lo inserta como cabeza
            }
            else // 3. Caso contrario recorremos el nodo hasta el último elemento
            {
                Nodo actual = head; // Empezamos el recorrido desde la cabeza
                while (actual.Next != null) // Mientras el siguiente no sea nulo
                {
                    actual = actual.Next; // Avanzamos al siguiente nodo
                }
                actual.Next = nuevoNodo; // 4. Insertamos el nodo nuevo al final
            }
        }

        public double CalcularPromedio() // Método para obtener el promedio de la lista
        {
            if (head == null) return 0; // Si la lista está vacía, devuelve cero
            double suma = 0; // Variable para acumular la suma de los datos
            int contador = 0; // Variable para contar cuántos datos hay
            Nodo? actual = head; // Empezamos desde la cabeza
            while (actual != null) // Mientras el nodo actual no sea nulo
            {
                suma += actual.Valor; // Sumamos el valor del nodo a la variable suma
                contador++; // Incrementamos el contador de elementos
                actual = actual.Next; // Pasamos al siguiente nodo
            }
            return suma / contador; // Retornamos el promedio (suma total entre cantidad)
        }

        public void MostrarLista() // Método para representar la lista (DibujarLista)
        {
            Nodo? actual = head; // Empezamos desde la cabeza
            Console.Write("head -->"); // Dibujamos el inicio de la representación
            while (actual != null) // Mientras haya nodos en la lista
            {
                Console.Write(" [ " + actual.Valor + " | * ]"); // Imprimimos el valor con el formato pedido
                if (actual.Next != null) // Si el siguiente no es nulo
                {
                    Console.Write(" -->"); // Dibujamos la flecha de enlace
                }
                actual = actual.Next; // Avanzamos al siguiente nodo
            }
            Console.Write(" --> null"); // Dibujamos el final de la lista apuntando a null
            Console.WriteLine(); // Salto de línea final
        }
    }
}
