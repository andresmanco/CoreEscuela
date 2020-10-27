using System;
using System.Collections.Generic;

namespace Etapa1.Entidades
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }

        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
        ///Constructor
        public Alumno()=> UniqueId = Guid.NewGuid().ToString();
    }
}