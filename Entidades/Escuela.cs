using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela: ObjetoEscuelaBase
    {
        string nombre;
        public string Nombre
        {
            get{ return nombre;}
            set{ nombre = value.ToUpper();}
        }
        public int AnoDeCreacion{get;set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; } 

        //CONSTRUCTOR
        public Escuela(string nombre, int ano)
        {
            this.Nombre = nombre;
            AnoDeCreacion = ano;
        }
        //Other constructor
        // public Escuela(string nombre, int ano) => (Nombre, AnoDeCreacion) = (nombre, ano);

        public Escuela(string nombre, int ano, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, AnoDeCreacion) = (nombre, ano);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }

}
}