using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumerPayments
{
    class ConsumerCash : Consumer
    {        
        public ConsumerCash(string firstName, string lastName) : base(firstName, lastName, "cash")
        { }

        public override void Pay() => Console.WriteLine("{0} {1} pay by {2}.", FirstName, LastName, Payment);
    }
}
