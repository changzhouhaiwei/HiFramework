
public class EventMgr
{
    private static EventMgr _mgr;

    public static EventMgr Inst
    {
        get
        {
            if (_mgr == null)
            {
                _mgr = new EventMgr();
            }
            return _mgr;
        }
    }

    public void Init()
    {
           
    }
    
    public void AddListener()
    {
                
    }

    public void Broadcast()
    {
        
    }
}
