
namespace InterfacQ32024
{
    /// <summary>
    /// Interfaz que contiene los métodos para calcular diferentes áreas matemáticas
    /// </summary>
    public interface IArea
    {
        /// <summary>
        /// Implementa el proceso de calcular el área de un cuadrado
        /// </summary>
        /// <returns>Area del cuadrado</returns>
        public double Cuadrado();

        /// <summary>
        /// Implementa el proceso de calcular el área de un triángulo
        /// </summary>
        /// <returns>Area del triángulo</returns>
        public double Triangulo();
    }
}
