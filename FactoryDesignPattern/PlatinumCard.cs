using FactoryDesignPattern.Contracts;
using System;

namespace FactoryDesignPattern
{
    public class PlatinumCard : ICard
    {
        public bool DoesCardExists(int id)
        {
            return true;
        }

        public Card CreateCard(int id)
        {
            Console.WriteLine("-----------PLATINUM CARD-----------");
            return new Card()
            {
                Id = id,
                Name = "Paltinum Benifits",
                Number = Guid.NewGuid().ToString(),
                Expiary = DateTime.UtcNow
            };
        }

    }
}
