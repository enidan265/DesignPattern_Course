using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    // Interface Mediator
    public interface IChatMediator
    {
        void SendMessage(string message, User sender);
        void SendPrivateMessage(string message, User receiver);
        void AddUser(User user);
    }
}
