namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verhindert enge Kopplung zwischen verschiedenen Objekten, die mit einander kommunizieren müssen 
            // Mediator-Objekt übernimmt die Kommunikation 

            // Beispiel: Chatroom 

            ChatMediatorImpl chatRoom = new ChatMediatorImpl();
            UserImpl user1 = new UserImpl(chatRoom, "Nadine");
            UserImpl user2 = new UserImpl(chatRoom, "Max");
            UserImpl user3 = new UserImpl(chatRoom, "Sabie");
            UserImpl user4 = new UserImpl(chatRoom, "Mashy");

            chatRoom.AddUser(user1);
            chatRoom.AddUser(user2);
            chatRoom.AddUser(user3);
            chatRoom.AddUser(user4);

            user3.SendMessage("Hallo Leute!");

            user4.SendPrivateMessage("Hallo Nadine", user1);
        }
    }
}
