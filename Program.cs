using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();            
            imprimirCursosEscuela(engine.Escuela);

            Printer.DibujarLinea(20);
            Printer.DibujarLinea(20);
            Printer.DibujarLinea(20);
            Printer.ImprimeTitulo("Pruebas de Polimorfismo");
            var alumnoTest = new Alumno{Nombre= "Claire Underwood"};
        }

        private static void imprimirCursosEscuela(Escuela escuela)
        {
            Printer.ImprimeTitulo($"Cursos de {escuela.Nombre}");

            // if (escuela != null && escuela.Cursos!= null)
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, ID: {curso.UniqueId}");
                }
            }
        }  
    }
}