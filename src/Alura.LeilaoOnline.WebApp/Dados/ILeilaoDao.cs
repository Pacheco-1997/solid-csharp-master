using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Categoria> BuscarCategorias();

        IEnumerable<Leilao> BuscarLeiloes();

        Leilao BuscarLeilaoPorId(int id);

        void IncluirLeilao(Leilao leilao);

        void AlterarLeilao(Leilao leilao);

        void ExcluirLeilao(Leilao leilao);

    }
}
