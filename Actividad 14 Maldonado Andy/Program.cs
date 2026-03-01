// Calcular el factorial de un número ingresado.

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());
int fact = 1;
int i = 1;

while(i <= num)
{
    fact *= i;
    i++;
}
Console.WriteLine($"El factorial de {num} es {fact}");
