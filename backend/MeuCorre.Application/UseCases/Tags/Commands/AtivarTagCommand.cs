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
    public class AtivarTagCommand : IRequest<(string, bool)>
    {
      

        [Required(ErrorMessage = "É necessário informar o ID ")]
        public required Guid Id { get; set; }
    }
    internal class AtivarTagCommandHandler : IRequestHandler<AtivarTagCommand, (string, bool)>
    {

        public Task<(string, bool)> Handle(AtivarTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}