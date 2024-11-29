using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    // Concrete Colleague 
    public class UserImpl : User
    {
        
        public UserImpl(IChatMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Name} hat eine Nachricht empfangen: {message}");
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"{Name}: {message}");
            Mediator.SendMessage(message, this);
        }

        public override void SendPrivateMessage(string message, User receiver)
        {
            Console.WriteLine($"{Name}: {message}");
            Mediator.SendPrivateMessage(message, receiver);
        }
    }
}
