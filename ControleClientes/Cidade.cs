using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }

        public ICollection<Cliente> Clientes { get; set; }        


    }
}
