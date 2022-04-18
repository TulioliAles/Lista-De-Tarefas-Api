using Flunt.Br;
using Flunt.Notifications;
using Flunt.Validations;
using ListaTarefas.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;

namespace ListaTarefas.Domain.Commands
{
    public class CreateListaTarefasCommand : Notifiable<Notification>,  ICommand
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

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            throw new NotImplementedException();
        }

        public void Validate()
        {
      
        }
    }
}
