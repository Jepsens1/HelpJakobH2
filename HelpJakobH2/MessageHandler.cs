using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakobH2
{
    class MessageHandler
    {
        MessageConverter converter = new MessageConverter();
        //Method to send a message
        public void SendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //Checks if message is SMTP or VMMessage
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = converter.ConvertBodyToHTML(m.Body);
                //Sends message
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = converter.ConvertBodyToHTML(m.Body);
                //Sends message
            }
        }
        public void SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = converter.ConvertBodyToHTML(m.Body);
                foreach (string person in to)
                {
                    //Sends message
                }
            }
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = converter.ConvertBodyToHTML(m.Body);
                foreach (string person in to)
                {
                    //Sends message
                }
            }
        }
    }    
}
