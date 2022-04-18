using Flunt.Notifications;
using ListaTarefas.Domain.Commands.Contracts;
using System;

namespace ListaTarefas.Domain.Commands
{
    class MarcarTarefaComoFeitaCommand : Notifiable<Notification>, ICommand
    {

        public MarcarTarefaComoFeitaCommand() { }

        public MarcarTarefaComoFeitaCommand(Guid id, string usuario)
        {
            Id = id;
            Usuario = usuario;
        }

        public Guid Id { get; set; }

        public string Usuario { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
