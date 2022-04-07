using EmpresaSixConsult.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaSixConsult.Repositorio
{
    interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
