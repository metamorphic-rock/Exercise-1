public class Program
{
    static void Main(string[] args)
    {
        SimCard simA=new SimCard("09222059559","Sun");
        SimCard simB=new SimCard("09323850237","Smart");

        MobilePhone phoneA=new MobilePhone("Honor","White","H1",simA);
        MobilePhone phoneB=new MobilePhone("Samsung","Blue","S1",simB);
        
        SmartPhone sPhoneA=new SmartPhone("Huawei","Dark blue","p50","edge", simA);
        SmartPhone sPhoneB=new SmartPhone("Apple", "Purple","i14","opera",simB);

        phoneA.Call("09323850237");
        sPhoneB.Call("09222059559");

        App a1=new App("App1", 10);
        App a2=new App("App2",5);
        App a3=new App("App3", 15);

        sPhoneA.AddApplication(a1);
        sPhoneA.AddApplication(a2);
        sPhoneA.AddApplication(a3);

        Console.WriteLine("Total size of apps is "+sPhoneA.GetTotalSize());
        



        
    }
}
