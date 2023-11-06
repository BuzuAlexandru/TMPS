namespace Kitchen;

public class Invoker
{
    private ICommand command;

    public Invoker(ICommand command)
    {
        this.command = command;
    }

    public ICommand Command
    {
        set { command = value; }
    }

    public void Execute()
    {
        command.Execute();
    }
}