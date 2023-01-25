public class MobilePhone
{
    public string brand{get; set;}
    public string color{get; set;}
    public string model{get; set;}

    public SimCard sim{get; set;}

    public MobilePhone(string brand, string color, string model, SimCard sim)
    {
        this.brand=brand;
        this.color=color;
        this.model=model;
        this.sim=sim;
    }
    public void ShowPhoneDetails()
    {
        Console.WriteLine("The phone details are:");
        Console.WriteLine(this.brand);
        Console.WriteLine(this.color);
        Console.WriteLine(this.model);

    }
    public string ShowPhoneNumber()
    {
        return sim.PhoneNumber;
    }
    public void SwapSimCard(SimCard newSim)
    {
        this.sim=newSim;
    }
    public void Call(string phoneNumber)
    {
        Console.WriteLine("Calling "+phoneNumber+ " from " +ShowPhoneNumber());
    }
    public void Call(MobilePhone mobilePhone)
    {
      Console.WriteLine("Calling "+ mobilePhone.ShowPhoneNumber()+ " from number" +ShowPhoneNumber());  
    }
}