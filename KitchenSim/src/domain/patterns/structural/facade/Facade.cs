namespace Kitchen;

public class Facade: IFacade
{
    protected ICondiment adapter;
    protected ILogger loggerProxy;

    public Facade(ICondiment adptr, ILogger lgr)
    {
        adapter = adptr;
        loggerProxy = lgr;
    }

    public void PerformOperation()
    {

    }
}