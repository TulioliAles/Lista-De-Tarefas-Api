using ListaTarefas.Domain.Commands.Contracts;
using System;

namespace ListaTarefas.Domain.Commands
{
    public class CreateListaTarefasCommand : ICommand
    {
        public CreateListaTarefasCommand() {}

        public CreateListaTarefasCommand(string titulo, string usuario, DateTime data)
        {
            Titulo = titulo;
            Usuario = usuario;
            Data = data;
        }

        public string Titulo { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
