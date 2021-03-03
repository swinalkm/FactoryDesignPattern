using FactoryDesignPattern.Contracts;
using System;

namespace FactoryDesignPattern
{
    public class SilverCard : ICard
    {
        public bool DoesCardExists(int id)
        {
            return true;
        }

        public Card CreateCard(int id)
        {
            Console.WriteLine("-----------SILVER CARD-----------");
            return new Card()
            {
                Id = id,
                Name = "Silver Benifits",
                Number = Guid.NewGuid().ToString(),
                Expiary = DateTime.UtcNow
            };
        }
    }
}
