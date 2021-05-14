using System;

namespace Biblioteca.Models
{
    public class Libros
    {
        public int Id { get; set; }
        public string titulo{get;set;}

        public int año{get;set;}

        public string autor{get;set;}
        public string genero{get;set;}
        public int cantidad {get;set;}
        public string portada{get;set;}
    }
}
