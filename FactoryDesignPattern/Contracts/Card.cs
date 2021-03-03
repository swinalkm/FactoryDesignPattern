using System;

namespace FactoryDesignPattern.Contracts
{
    public class Card
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public DateTime Expiary { get; set; }

        internal void write()
        {
            Console.WriteLine("1. Id : " + Id);
            Console.WriteLine("2. Number : " + Number);
            Console.WriteLine("3. Name : " + Name);
            Console.WriteLine("4. Expiary : " + Expiary);
        }
    }
}
