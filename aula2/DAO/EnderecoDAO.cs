using aula2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula2.DAO
{
    public class EnderecoDAO
    {
        private readonly Context _context;
     
        public EnderecoDAO(Context context)
        {
            _context = context;
        }

        public void Cadastrar(Endereco e)
        {
            _context.Endereco.Add(e);
            _context.SaveChanges();
        }

        public List<Endereco> Listar()
        {
            return _context.Endereco.ToList();
        }

    }
}
