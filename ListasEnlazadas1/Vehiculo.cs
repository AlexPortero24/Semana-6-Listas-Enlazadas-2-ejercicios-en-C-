namespace Estacionamiento
{
    // Definición de la clase Nodo para representar un vehículo
    public class Nodo
    {
        // Atributos del vehículo solicitados por el Área de Ingeniería
        public string Placa;    // Almacena el número de placa
        public string Marca;    // Almacena la marca del fabricante
        public string Modelo;   // Almacena el nombre del modelo
        public int Año;         // Almacena el año de fabricación
        public double Precio;   // Almacena el valor monetario
        
        // Enlace al siguiente elemento de la lista enlazada simple
        public Nodo? Next; 

        // Constructor para inicializar los datos del nuevo vehículo
        public Nodo(string placa, string marca, string modelo, int año, double precio)
        {
            Placa = placa;      // Asigna la placa recibida
            Marca = marca;      // Asigna la marca recibida
            Modelo = modelo;    // Asigna el modelo recibido
            Año = año;          // Asigna el año recibido
            Precio = precio;    // Asigna el precio recibido
            Next = null;        // Por defecto, el siguiente nodo es nulo
        }
    }
}

