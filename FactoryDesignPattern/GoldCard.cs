using FactoryDesignPattern.Contracts;
using System;

namespace FactoryDesignPattern
{
    public class GoldCard : ICard
    {
        public bool DoesCardExists(int id)
        {
            return true;
        }

        public Card CreateCard(int id)
        {
            Console.WriteLine("-----------GOLD CARD-----------");
            return new Card()
            {
                Id = id,
                Name = "Gold Benifits",
                Number = Guid.NewGuid().ToString(),
                Expiary = DateTime.UtcNow
            };
        }
    }
}
