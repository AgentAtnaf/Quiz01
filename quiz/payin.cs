public class Payinmoney
{
    public string[] weekinshop = {"3,302","3,429","4,445","6530"};
    public string[] weekoutshop = {"27,846","34,272","59,763","96,747"};
    public string[] allincome = {"17,526","218,628"};
    public string[] staff = {"15,000","15,000","15,000","12,500","12,500"};
    public string[] salesshare = {"1873.3","1959.025","1996.525","2677.5","2173.2"};
    public string[] fare = {"8,500","8,500","8,500","8,500","8,500",};
    public string[] Shippingcost = {"0","0","0","45000","45600"};
    public string[] alloutcome ={"70000","10,676.55","42500","90,600"};
    public void Printincome()
    {
        Console.WriteLine("Week 1 {0} {1} ",weekinshop[0],weekoutshop[0]);
        Console.WriteLine("Week 2 {0} {1} ",weekinshop[1],weekoutshop[1]);
        Console.WriteLine("Week 3 {0} {1} ",weekinshop[2],weekoutshop[2]);
        Console.WriteLine("Week 4 {0} {1} ",weekinshop[3],weekoutshop[3]);
        Console.WriteLine("Total: {0} {1} ",allincome[0],allincome[1]);
    }
    public void Printoutcome()
    {
        Console.WriteLine("Week 1 {0} {1} {2} {3} ",staff[0],salesshare[0],fare[0],Shippingcost[0]);
        Console.WriteLine("Week 2 {0} {1} {2} {3} ",staff[1],salesshare[1],fare[1],Shippingcost[1]);
        Console.WriteLine("Week 3 {0} {1} {2} {3} ",staff[2],salesshare[2],fare[2],Shippingcost[2]);
        Console.WriteLine("Week 4 {0} {1} {2} {3} ",staff[3],salesshare[3],fare[3],Shippingcost[3]);
        Console.WriteLine("Total: {0} {1} {2} {3} ",alloutcome[0],alloutcome[1],alloutcome[2],alloutcome[3]);
    }
    public void result()
    {
        Console.WriteLine("Total income: 236,154 Total outcome 213,776.55");
        Console.WriteLine("Total left: 22.55");
    }
}