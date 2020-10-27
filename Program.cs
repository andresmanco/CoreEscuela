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
            imprimirEvaluaciones(engine.Escuela);


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

        private static void imprimirEvaluaciones(Escuela escuela){
            if(escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        foreach (var evaluacion in alumno.Evaluaciones)
                        {
                            Printer.DibujarLinea(50);
                            WriteLine($"Asignatura: {evaluacion.Asignatura.Nombre}");
                            WriteLine($"Nombre: {evaluacion.Nombre}, Alumno: {evaluacion.Alumno.Nombre}, Nota: {evaluacion.Nota}");
                        }
                    }
                }
            }
        }
    }
}