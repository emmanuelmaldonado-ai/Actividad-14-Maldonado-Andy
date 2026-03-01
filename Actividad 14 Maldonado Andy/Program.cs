// Sumar números ingresados hasta que el total supere 100.

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());
int suma = 0;
suma += num;

while(suma <= 100)
{
    Console.WriteLine("Ingrese un número");
    num = int.Parse(Console.ReadLine());
    suma += num;
}
Console.WriteLine($"Se ha sumerado a 100 con {suma}");
