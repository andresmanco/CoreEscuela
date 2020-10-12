using System;

namespace Etapa1.Entidades
{
    public class Evaluacion

    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }

        ///Constructor
        public Evaluacion
        ()=> UniqueId = Guid.NewGuid().ToString();
    }
}