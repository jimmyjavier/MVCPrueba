using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPrueba.Models
{
    public class TipoCliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }

    }
}