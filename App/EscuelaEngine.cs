using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;
using Etapa1.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine() { }

        public void Inicializar()
        {
            Escuela = new Escuela("Academia Platzi", 2012, TiposEscuela.Primaria, "Venezuela", "Caracas");
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }
        private void CargarEvaluaciones()
        {
            var lista = new List<Evaluacion>();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluacion{ 
                                Nombre = $"{asignatura.Nombre} Ev#{i+1}", 
                                Alumno = alumno, 
                                Asignatura = asignatura, 
                                Nota = NotaRandom(rnd)};
                            alumno.Evaluaciones.Add(ev);
                        }  
                    }
                }
            }
        }

        static float NotaRandom(Random random) 
        { 
            double resultado = (random.NextDouble() * 5.0) - 0.0;
            return (float)(Math.Round(resultado, 1)); 
        } 


        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listAsignaturas = new List<Asignatura>(){
                    new Asignatura{ Nombre = "Matematicas"},
                    new Asignatura{ Nombre = "Edufacion Fisica"},
                    new Asignatura{ Nombre = "Castellano"},
                    new Asignatura{ Nombre = "Ciencias Naturales"},
                };
                curso.Asignaturas = listAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            
            return listaAlumnos.OrderBy(alumno => alumno.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso{ Nombre = "101", Jornada = TiposJornada.Manana},
                new Curso{ Nombre = "201", Jornada = TiposJornada.Manana},
                new Curso{ Nombre = "301", Jornada = TiposJornada.Manana},
                new Curso{ Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso{ Nombre = "501", Jornada = TiposJornada.Tarde}
            };

            ///Inicializa objeto tipo Random para crear 
            ///numero random entre 5 y 20
            Random random = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = random.Next(5, 20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
    }
}