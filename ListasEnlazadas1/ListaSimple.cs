using System; // Uso de librerías básicas del sistema

namespace Estacionamiento
{
    // Clase que gestiona la lógica de la lista enlazada
    public class ListaSimple
    {
        private Nodo? head; // Puntero inicial de la lista (Cabeza)

        // Constructor que inicializa la lista vacía
        public ListaSimple() { head = null; }

        // Método para agregar un vehículo al final (Operación a)
        public void InsertarFinal(string p, string m, string mod, int a, double pre)
        {
            Nodo nuevoNodo = new Nodo(p, m, mod, a, pre); // Se crea el nodo con los datos
            if (head == null) { head = nuevoNodo; } // Si la lista está vacía, el nuevo nodo es la cabeza
            else // Si no está vacía, se debe recorrer
            {
                Nodo actual = head; // Empezamos desde la cabeza
                while (actual.Next != null) { actual = actual.Next; } // Avanzamos hasta el último nodo
                actual.Next = nuevoNodo; // Enlazamos el último nodo con el nuevo
            }
        }

        // Método para buscar vehículo por placa (Operación b)
        public Nodo? Buscar(string placa)
        {
            Nodo? actual = head; // Empezamos la búsqueda desde la cabeza
            while (actual != null) // Mientras no lleguemos al final de la lista
            {
                if (actual.Placa.ToUpper() == placa.ToUpper()) return actual; // Si coincide la placa, devolvemos el nodo
                actual = actual.Next; // Pasamos al siguiente nodo
            }
            return null; // Si termina el ciclo y no encontró nada, devuelve nulo
        }

        // Método para filtrar vehículos por año (Operación c)
        public void VerPorAño(int añoBusqueda)
        {
            Nodo? actual = head; // Empezamos desde el inicio
            bool encontrado = false; // Bandera para saber si hubo resultados
            while (actual != null) // Recorremos toda la lista
            {
                if (actual.Año == añoBusqueda) // Si el año coincide con el buscado
                {
                    Console.WriteLine($"-> {actual.Placa}: {actual.Marca} {actual.Modelo}"); // Imprimimos datos básicos
                    encontrado = true; // Marcamos que encontramos al menos uno
                }
                actual = actual.Next; // Movemos al siguiente vehículo
            }
            if (!encontrado) Console.WriteLine("No hay vehículos registrados de ese año."); // Mensaje si no hubo coincidencias
        }

        // Método para mostrar todos los vehículos (Operación d)
        public void DibujarLista()
        {
            Nodo? actual = head; // Iniciamos en la cabeza
            Console.Write("head -->"); // Dibujo estético de inicio
            while (actual != null) // Mientras haya nodos
            {
                Console.Write($" [ {actual.Placa} | * ]"); // Dibujamos el nodo actual con su placa
                if (actual.Next != null) Console.Write(" -->"); // Si hay otro después, dibujamos la flecha
                actual = actual.Next; // Avanzamos al siguiente
            }
            Console.WriteLine(" --> null"); // Fin de la lista
        }

        // Método para eliminar un vehículo por su placa (Operación e)
        public void Eliminar(string placa)
        {
            if (head == null) return; // Si la lista está vacía, no hacemos nada
            
            // Caso especial: El vehículo a eliminar es el primero (head)
            if (head.Placa.ToUpper() == placa.ToUpper())
            {
                head = head.Next; // La cabeza ahora es el segundo elemento
                Console.WriteLine("Vehículo eliminado."); // Confirmación
                return; // Salimos del método
            }

            Nodo actual = head; // Empezamos desde la cabeza para buscar en el resto
            // Buscamos el nodo que está ANTES del que queremos borrar
            while (actual.Next != null && actual.Next.Placa.ToUpper() != placa.ToUpper())
            {
                actual = actual.Next; // Avanzamos un lugar
            }

            if (actual.Next != null) // Si encontramos el nodo
            {
                actual.Next = actual.Next.Next; // Saltamos el nodo a eliminar apuntando al siguiente del siguiente
                Console.WriteLine("Vehículo eliminado."); // Confirmación
            }
            else { Console.WriteLine("No se encontró ningún vehículo con esa placa."); } // Error si no existe
        }
    }
}
