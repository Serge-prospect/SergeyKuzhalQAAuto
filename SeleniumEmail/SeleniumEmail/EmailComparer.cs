using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumEmail
{
    public class EmailComparer : IEqualityComparer<Email>
    {
        public bool Equals(Email initial, Email fromPage)
        {
            return ((fromPage.Subject.Contains(initial.Subject)
                && fromPage.From.Contains(initial.From)
                && fromPage.To.Contains(initial.To)
                && fromPage.Message.Contains(initial.Message)));
        }

        public int GetHashCode(Email obj)
        {
            throw new NotImplementedException();
        }
    }
}
