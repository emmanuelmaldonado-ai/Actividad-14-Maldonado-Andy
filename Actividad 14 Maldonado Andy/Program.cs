// Contar cuántos números positivos ingresa el usuario.

//ingrese 0 para salir o terminar
int num = 1;
int posi = 0;
while(num != 0)
{
    Console.WriteLine("Ingrese un número");
    num = int.Parse(Console.ReadLine());
    if(num > 0)
    {
        posi++;
    }
}
Console.WriteLine($"ingresó {posi} números positivos");
