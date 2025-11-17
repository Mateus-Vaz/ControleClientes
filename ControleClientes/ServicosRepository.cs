using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
   public class ServicoRepository : Servico
    {
        private readonly AppDbContext _context;
        public ServicoRepository()
        {
            _context = new AppDbContext();
        }
       public void Adicionar(Servico Servico)
        {
            _context.Add(Servico);
            _context.SaveChanges();
        }
        public List<Servico> ListarTodos()
        {
            return _context.Servicos.ToList();
        }
        public Servico ObterPorId(int id) =>_context.Servicos.FirstOrDefault(c=> c.Id == id);

        public IEnumerable<Servico> ObterPorNome(string nome)
        {
            return _context.Servicos.Where(c => c.Nome.Contains(nome)).ToList();
        }

        public void Atualizar(Servico Servico)
        {
            Servico ServicoExistente = ObterPorId(Servico.Id);
            if (ServicoExistente != null)
            {
                ServicoExistente.Nome = Servico.Nome;
                
                _context.SaveChanges();
            }
        }
        public void Remover(int id)
        {
            var Servico = _context.Set<Servico>().Find(id);
            if (Servico != null)
            {
                _context.Set<Servico>().Remove(Servico);
                _context.SaveChanges();
            }
        }

    }
}
