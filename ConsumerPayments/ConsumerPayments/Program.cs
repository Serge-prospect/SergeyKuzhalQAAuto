using System;

namespace ConsumerPayments
{
    class Program
    {
        static void Main(string[] args)
        {
            var consumers = new Consumer[5];

            consumers[0] = new ConsumerCash("John", "Dore");
            consumers[1] = new ConsumerDebit("Kate", "Brown");
            consumers[2] = new ConsumerCredit("Jane", "Clark");
            consumers[3] = new ConsumerCredit("Mark", "Smith");
            consumers[4] = new ConsumerCash("Ben", "Gun");

            foreach(var consumer in consumers)            
                consumer.Pay();            
        }
    }
}
