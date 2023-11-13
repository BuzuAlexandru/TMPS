namespace Kitchen;

public class Invoker: IInvoker
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

    public void Invoke()
    {
        command.Execute();
    }
}