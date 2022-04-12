using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumerPayments
{
    class ConsumerDebit : Consumer
    {
        public ConsumerDebit(string firstName, string lastName) : base(firstName, lastName, "debit card")
        { }

        public override void Pay() => Console.WriteLine("{0} {1} pay by {2}.", FirstName, LastName, Payment);
    }
}
