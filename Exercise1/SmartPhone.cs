public class SmartPhone:MobilePhone
{
    public string browser{get;set;}
    public List<App> applications {get; set;}
    public SmartPhone(string brand, string color, string model,string browser,SimCard sim):base(brand, color, model,sim)
    {
        this.browser=browser;
        this.applications=new List<App>();
    }
    public void CallFromBrowser(string phoneNumber)
    {
        Console.WriteLine("calling from "+browser);
    }
    public void CallFromBrowser(MobilePhone mobilePhone)
    {
        Console.WriteLine("calling from "+browser);
        base.Call(mobilePhone);
    }
    public void AddApplication(App application)
    {
        this.applications.Add(application);
    }
    public float GetTotalSize()
    {
        float TotalSize=0;
        foreach(App app in applications)
        {
            TotalSize=TotalSize + app.size;
            Console.WriteLine(app.name);
        }
        return TotalSize;
    }
}