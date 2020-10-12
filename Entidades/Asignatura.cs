using System;
using System.Collections.Generic;

namespace Etapa1.Entidades
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }
        public List<Evaluacion> Evaluaciones { get; set; }
        ///Constructor
        public Asignatura()=> UniqueId = Guid.NewGuid().ToString();
    }
}