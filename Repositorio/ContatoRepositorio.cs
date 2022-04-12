using EmpresaSixConsult.Data;
using EmpresaSixConsult.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaSixConsult.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext  bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        //implementar interface
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.contatos.ToList();
        }
    }
}
