using System;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
    public class Prestamos
    {
        public int Id{get;set;}
        public int idUsuario{get;set;}
        public bool estado{get;set;}
        [DataType(DataType.Date)]
        public DateTime fechaPres{get;set;}
        [DataType(DataType.Date)]
        public DateTime fechaRe{get;set;}
    }
}