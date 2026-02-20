using System;

class Program
{
    static void Main()
    {
        // ===============================
        // 1️⃣ Calculadora Modular
        // ===============================
        Console.WriteLine("=== CALCULADORA MODULAR ===");

        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Suma: " + Sumar(num1, num2));
        Console.WriteLine("Resta: " + Restar(num1, num2));
        Console.WriteLine("Multiplicación: " + Multiplicar(num1, num2));
        Console.WriteLine("División: " + Dividir(num1, num2));

        // ===============================
        // 2️⃣ Validador de Acceso
        // ===============================
        Console.WriteLine("\n=== VALIDADOR DE EDAD ===");

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        ValidarEdad(edad);

        // ===============================
        // 3️⃣ Formulario Flexible
        // ===============================
        Console.WriteLine("\n=== FORMULARIO FLEXIBLE ===");

        CrearPerfil("Gary", "Gimnasio");
        CrearPerfil("Carlos");
    }

    // ===============================
    // FUNCIONES CALCULADORA
    // ===============================

    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Restar(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("No se puede dividir entre cero.");
            return 0;
        }
        return a / b;
    }

    // ===============================
    // FUNCION VOID
    // ===============================

    static void ValidarEdad(int edad)
    {
        if (edad < 18)
            Console.WriteLine("Acceso Denegado");
        else
            Console.WriteLine("Bienvenido");
    }

    // ===============================
    // PARAMETRO OPCIONAL
    // ===============================

    static void CrearPerfil(string nombre, string hobby = "Dormir")
    {
        Console.WriteLine("\nPerfil creado:");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Hobby: " + hobby);
    }
}