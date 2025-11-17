using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
   public class CidadeRepository : Cidade
    {
        private readonly AppDbContext _context;
        public CidadeRepository()
        {
            _context = new AppDbContext();
        }
       public void Adicionar(Cidade cidade)
        {
            _context.Add(cidade);
            _context.SaveChanges();
        }
        public List<Cidade> ListarTodos()
        {
            return _context.Cidades.ToList();
        }
        public Cidade ObterPorId(int id) =>_context.Cidades.FirstOrDefault(c=> c.Id == id);

        public IEnumerable<Cidade> ObterPorNome(string nome)
        {
            return _context.Cidades.Where(c => c.Nome.Contains(nome)).ToList();
        }

        public void Atualizar(Cidade cidade)
        {
            Cidade cidadeExistente = ObterPorId(cidade.Id);
            if (cidadeExistente != null)
            {
                cidadeExistente.Nome = cidade.Nome;
                cidadeExistente.Uf = cidade.Uf;
                _context.SaveChanges();
            }
        }
        public void Remover(int id)
        {
            var cidade = _context.Set<Cidade>().Find(id);
            if (cidade != null)
            {
                _context.Set<Cidade>().Remove(cidade);
                _context.SaveChanges();
            }
        }

    }
}
