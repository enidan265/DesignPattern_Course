using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    // abstract Colleague
    public abstract class User
    {
        public IChatMediator Mediator { get; set; }
        public string Name { get; set; }

        public User(IChatMediator mediator, string name)
        {
            Mediator = mediator;
            Name = name;
        }

        public abstract void SendMessage(string message);
        public abstract void SendPrivateMessage(string message, User receiver);
        public abstract void ReceiveMessage(string message);
    }
}
