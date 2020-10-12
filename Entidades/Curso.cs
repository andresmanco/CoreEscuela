using System;
using System.Collections.Generic;
using Etapa1.Entidades;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }
        public TiposJornada Jornada { get; set; }    
        
        public List<Asignatura> Asignaturas {get; set;}

        public List<Alumno> Alumnos { get; set; }

        //Constructor
        public Curso()=> UniqueId = Guid.NewGuid().ToString();
        
    }
}