// Contar cuántos dígitos tiene un número.

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());
int digito = 0;
int i = num;

while(i > 0)
{
    i /= 10;
    digito ++;
}
Console.WriteLine($"Tiene {digito } digitos");
