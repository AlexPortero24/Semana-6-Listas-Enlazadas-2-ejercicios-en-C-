namespace Estacionamiento // Espacio de nombres unificado
{
    public class Nodo // Definición de la clase Nodo
    {
        public double Valor; // Variable para almacenar el dato real (punto flotante)
        public Nodo? Next; // Referencia al siguiente nodo (puntero Next)

        public Nodo(double valor) // Constructor del nodo
        {
            this.Valor = valor; // Asigna el valor pasado como parámetro a la variable Valor
            this.Next = null; // Inicializa el puntero siguiente como nulo
        }
    }
}
