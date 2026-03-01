//Pedir números hasta que el usuario ingrese 0.

Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());

while(num != 0)
{
    Console.WriteLine($"Ingresó{num}");
    Console.WriteLine("ingresar un numero");
    num = int.Parse(Console.ReadLine());
}
