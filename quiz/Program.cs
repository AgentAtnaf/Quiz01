
public class Program 
{

static int number = 0;
public static void Main(string []args)
{
    User staff = new User();
Owner owner = new Owner();
Cofoundersinformation cofounder = new Cofoundersinformation();
Payinmoney payin = new Payinmoney();
    Console.WriteLine("Welcome to our shop information.");
    Console.WriteLine("what do you want to see ?");
    number = int.Parse(Console.ReadLine());
    if(number == 1)
    {
        staff.PrintUserInformation();
    }
    else if(number == 2)
    {
        owner.printowner();
    }
    else if(number == 3)
    {
        cofounder.PrintCofoundation();
    }
    else 
    {
        payin.Printincome();
        payin.Printoutcome();
        payin.result();
    }
}
}