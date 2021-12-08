using System;

namespace HelpJakobH2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance a messagehandler and Message
            MessageHandler messageHandler = new MessageHandler();
            Message message = new Message("Caro", "Phil", "Hello", "greeting", "Camil");

            //Sends a message
            messageHandler.SendMessage(MessageCarrier.VMessage, message, true);
            //Creating a string array, with people we are sending a message to
            string[] To = new string[] { "Bob", "Per" };

            //Calls method to send a message, with our string array as parameter
            messageHandler.SendMessageToAll(MessageCarrier.Smtp, To, message, true);
        }
    }
}
