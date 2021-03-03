namespace FactoryDesignPattern.Contracts
{
    public interface ICard
    {
        Card CreateCard(int id);
        bool DoesCardExists(int id);
    }
}
