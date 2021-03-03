namespace FactoryDesignPattern.Contracts
{
    public interface ICardFactory
    {
        ICard GetCard(string type);
    }
}
