using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPrueba.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int TipoClienteId { get; set; }
        public virtual TipoCliente TipoCliente { get; set; }
    }
}