using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    // concrete Mediator
    public class ChatMediatorImpl : IChatMediator
    {
        private List<User> userList;

        public ChatMediatorImpl()
        {
            this.userList = new List<User>();
        }
        
        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach(User u in  userList)
            {
                if(u != user)
                {
                    u.ReceiveMessage(message);
                }
            }
        }

        public void SendPrivateMessage(string message, User receiver)
        {
            receiver.ReceiveMessage(message);
        }
    }
}
