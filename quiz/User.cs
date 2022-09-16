public class User
{   
    public string[] Role = {"Fulltime","Fulltime","Fulltime","Driver","Driver"};
    public string[] name = {"chaide","Nornde","Apaide","Trumde","Nornde"};
    public string[] surname= {"luxde ","jaide ","reande","Ngande","reande "};
    public string[] Age= {"20","18","22","25","23"};
    public string[] salary = {"15,000","15,000","15,000","12,500","12,500"};
    public void PrintUserInformation() 
    {
        Console.WriteLine("{0} {1} {2} {3} {4]",Role[0],name[1],surname[2],Age[3],salary[4]);
        Console.WriteLine("{0} {1} {2} {3} {4]",Role[0],name[1],surname[2],Age[3],salary[4]);
        Console.WriteLine("{0} {1} {2} {3} {4]",Role[0],name[1],surname[2],Age[3],salary[4]);
        Console.WriteLine("{0} {1} {2} {3} {4]",Role[0],name[1],surname[2],Age[3],salary[4]);
        Console.WriteLine("{0} {1} {2} {3} {4]",Role[0],name[1],surname[2],Age[3],salary[4]);
    }
}