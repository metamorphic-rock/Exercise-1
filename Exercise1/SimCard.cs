public class SimCard
{
    private string phoneNumber;
    private string network;
    public string PhoneNumber
    {
        get {return phoneNumber;}
    }
    public SimCard(string phoneNumber, string network)
    {
        this.phoneNumber=phoneNumber;
        this.network=network;
    }
    public string getPhoneNumber()
    {
        return this.phoneNumber;
    }
    public void showSimDetails(){
        Console.WriteLine("The phone number is: "+ this.phoneNumber +" and the network is "+this.network);
    }
}