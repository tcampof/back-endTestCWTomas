using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace back_endTestCWTomas.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        [Column (TypeName ="nvarchar(100)")]
        public string Nombre { get; set; }
        [Column (TypeName ="nvarchar(100)")]
        public string Apellido { get; set; }
        [Column (TypeName ="nvarchar(100)")]
        public string Identificacion { get; set; }
        [Column (TypeName ="nvarchar(100)")]
        public string Direccion { get; set; }
    }
}
