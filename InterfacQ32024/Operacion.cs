
namespace InterfacQ32024
{
    public class Operacion : IOperacion, IArea
    {
        public double N1;

        public double N2;

        public double Division()
        {
            return N1 / N2;
        }

        public double Multiplicacion()
        {
            return N1 * N2;
        }

        public double Resta()
        {
            return N1 - N2;
        }

        public double Suma()
        {
            return N1 + N2;
        }

        public double Cuadrado()
        {
            return N1 * N2;
        }

        public double Triangulo()
        {
            return N1 * N2 / 2;
        }

        public void Imprimir()
        {
            Console.WriteLine($"La Suma es: {Suma()}");
            Console.WriteLine($"La Resta es: {Resta()}");
            Console.WriteLine($"La Multiplicación es: {Multiplicacion()}");
            Console.WriteLine($"La División es: {Division()}");
            Console.WriteLine($"El área del cuadrado es: {Cuadrado()}");
            Console.WriteLine($"El área del triángulo es: {Triangulo()}");
        }
    }
}
