using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumEmail
{
    public class Email
    {
        public string Subject { get; }
        public string From { get; }
        public string To { get; }
        public string Message { get; }

        public Email(string subject, string from, string to, string message)
        {
            Subject = subject;
            From = from;
            To = to;
            Message = message;
        }
    }
}
