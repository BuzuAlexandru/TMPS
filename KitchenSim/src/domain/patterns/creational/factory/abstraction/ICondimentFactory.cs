namespace Kitchen;
public interface ICondimentFactory
{
    public ICondiment CreateHerb();
    public ICondiment CreateSalt();
    public ICondiment CreateSpice();
}