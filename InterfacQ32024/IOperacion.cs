
namespace InterfacQ32024
{
    /// <summary>
    /// Interfaz que contiene los métodos para calcular las diferentes operaciones básicas
    /// </summary>
    public interface IOperacion
    {
        /// <summary>
        /// Implementa el proceso de una suma
        /// </summary>
        /// <returns>Total de la suma</returns>
        public double Suma();

        /// <summary>
        /// Implementa el proceso de una resta
        /// </summary>
        /// <returns>Total de la resta</returns>
        public double Resta();

        /// <summary>
        /// Implementa el proceso de una multiplicación
        /// </summary>
        /// <returns>Total de la multiplicación</returns>
        public double Multiplicacion();

        /// <summary>
        /// Implementa el proceso de una división
        /// </summary>
        /// <returns>Total de la división</returns>
        public double Division();

    }
}
