
using InterfacQ32024;

Operacion operacion = new Operacion();
Console.WriteLine("Ingrese primer número:");
bool validN1 = double.TryParse(Console.ReadLine(), out operacion.N1);

Console.WriteLine("Ingrese segundo número:");
bool validN2 = double.TryParse(Console.ReadLine(), out operacion.N2);

Console.WriteLine();
if (validN1 && validN2)
{
    if (operacion.N2 != 0)
    {
        operacion.Imprimir();
    } else
    {
        Console.WriteLine("Segundo valor no puede ser cero");
    }
} else
{
    Console.WriteLine("Uno de los valores o los valores ingresados no tiene el formato correcto...");
}