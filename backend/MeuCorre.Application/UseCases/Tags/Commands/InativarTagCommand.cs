using MediatR;
using MeuCorre.Application.UseCases.Categorias.Commands;
using MeuCorre.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    public class InativarTagHandler : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "É necessário informar o ID da T")]
        public required Guid CategoriaId { get; set; }
    }
    internal class InativarTagCommandHandler : IRequestHandler<InativarCategoriaCommand, (string, bool)>
    {

        public Task<(string, bool)> Handle(InativarCategoriaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}