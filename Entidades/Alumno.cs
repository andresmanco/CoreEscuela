using System;

namespace Etapa1.Entidades
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }
        ///Constructor
        public Alumno()=> UniqueId = Guid.NewGuid().ToString();
    }
}