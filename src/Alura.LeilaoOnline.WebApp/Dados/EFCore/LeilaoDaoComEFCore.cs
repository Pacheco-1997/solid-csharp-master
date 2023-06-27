using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EFCore
{
    public class LeilaoDaoComEFCore : ILeilaoDao
    {
        private readonly AppDbContext _context;

        public LeilaoDaoComEFCore(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }

        public IEnumerable<Leilao> BuscarLeiloes()
        {
            return _context.Leiloes
                .Include(l => l.Categoria)
                .ToList();
        }

        public Leilao BuscarLeilaoPorId(int id)
        {
            return _context.Leiloes.Find(id);
        }

        public void IncluirLeilao(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void AlterarLeilao(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void ExcluirLeilao(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}
