using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakobH2
{
    public enum MessageCarrier { Smtp, VMessage }

    public class Message
    {
        //Properties for a message
        public string To { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string Cc { get; set; }

        //Constructor
        public Message(string to, string from, string body, string subject, string cc)
        {
            To = to;
            From = from;
            Body = body;
            Subject = subject;
            Cc = cc;
        }
    }
}
