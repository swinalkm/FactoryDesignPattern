using FactoryDesignPattern.Contracts;

namespace FactoryDesignPattern
{
    public class CardFactory : ICardFactory
    {
        public ICard GetCard(string type)
        {
            if (type == "silver")
            {
                return new SilverCard();
            }
            if (type == "gold")
            {
                return new GoldCard();
            }
            if (type == "platinum")
            {
                return new PlatinumCard();
            }
            return null;
        }
    }
}
