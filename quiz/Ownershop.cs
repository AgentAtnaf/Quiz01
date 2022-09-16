public class Owner
{
    public string Registered = "1,000,000 baht";
    public string Shopname = "Bang Khun Thian, Seaside";
    public string location =" Bang Khun Thian, Seaside";
    public void printowner()
    {
        Console.WriteLine("{0}",Registered);
        Console.WriteLine("{0}",Shopname);
        Console.WriteLine("{0}",location);
    }
}