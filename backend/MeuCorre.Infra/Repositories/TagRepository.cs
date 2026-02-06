using MeuCorre.Domain.Entities;
using MeuCorre.Domain.Enums;
using MeuCorre.Domain.Interfaces.Repositories;
using MeuCorre.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Infra.Repositories
{
    public class TagRepository : ITagRepository 
    {
        private readonly MeuDbContext _meuDbcontext;
        public TagRepository(MeuDbContext meuDbContext)
        {
            _meuDbcontext = meuDbContext;
        }

        public async Task AdicionarAsync(Tag tag)
        {
            _meuDbcontext.Tags.Add(tag);
            await _meuDbcontext.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Tag tag)
        {
            _meuDbcontext.Tags.Update(tag);
            await _meuDbcontext.SaveChangesAsync();
        }

        public Task<bool> ExisteAsync(Guid tagId)
        {
           var existe = _meuDbcontext.Tags.AnyAsync(t => t.Id == tagId);
            return existe;
        }

        public async Task<IList<Tag>> ListarTodasPorUsuarioAsync(Guid usuarioId)
        {
            var listaDeTags = _meuDbcontext.Tags
                 .Where(c => c.UsuarioId == usuarioId);

            return await listaDeTags.ToListAsync();
        }

        public Task<bool> NomeExisteParaUsuarioAsync(string nome, Guid usuarioId)
        {
           var existe = _meuDbcontext.Tags
                .AnyAsync(
                            t => t.Nome == nome &&
                            t.UsuarioId == usuarioId
                        );
            return existe;
        }

        public Task<Tag?> ObterPorIdAsync(Guid tagId)
        {
            var tag = _meuDbcontext.Tags.FirstOrDefaultAsync(t => t.Id == tagId);
            return tag;
        }

        public async Task RemoverAsync(Tag tag)
        {
            _meuDbcontext.Tags.Remove(tag);
            await _meuDbcontext.SaveChangesAsync();

        }
    }
}
