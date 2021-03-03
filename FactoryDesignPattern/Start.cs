using FactoryDesignPattern.Contracts;
using System;

namespace FactoryDesignPattern
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------FACTORY--------------");
            ICardFactory cardFactory = new CardFactory();
            var goldCard = cardFactory.GetCard("gold");
            goldCard.CreateCard(1).write();

            var silverCard = cardFactory.GetCard("silver");
            silverCard.CreateCard(2).write();

            var platinumCard = cardFactory.GetCard("platinum");
            platinumCard.CreateCard(3).write();
        }
    }
}
