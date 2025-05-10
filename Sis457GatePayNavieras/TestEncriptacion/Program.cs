using System;

class Program
{
    static void Main()
    {
        string passwordPlano = "admin123";
        string passwordEncriptado = Util.Encrypt(passwordPlano);

        Console.WriteLine("Contraseña encriptada:");
        Console.WriteLine(passwordEncriptado);

        Console.ReadLine(); // Para que no se cierre la ventana
    }
}
