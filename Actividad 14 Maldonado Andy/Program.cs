// Pedir una contraseña hasta que sea correcta

string correcta = "123456";
string contra = "";

while(contra != correcta)
{
    Console.WriteLine("Intente su contraseña (123456) ");
    contra = Console.ReadLine();
}
Console.WriteLine("Contraseña correcta");
