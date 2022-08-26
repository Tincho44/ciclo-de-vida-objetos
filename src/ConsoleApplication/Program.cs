//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train();
            train.StartEngines();
            
            Train t1 = new Train ("Last Train To London");
            Train t2 = new Train ("Last Train To London");
            Train t3 = new Train ("Runaway Train");
            Console.WriteLine(t1 == t2); 
            Console.WriteLine(t2 == t3);
            // da False, mismos atributos pero eso no significa que sean el mismo objeto. Ambos hace referencia a otra parte de la memoria.
        }
    }
}