using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Genero Genero { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }        
        public string Uf { get; set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
    }
}
