using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,z;
               a=int.Parse( Console.ReadLine());
            c = (int)a;
             b=int.Parse(Console.ReadLine());
            z = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
           /* string ab; 
           
                ab= Console.ReadLine();
            string bc;
                bc= Console.ReadLine();
            a = int.Parse(ab);
            b = int.Parse(bc);

            int Z = a + b;
            Console.WriteLine(Z);
            */


        }
    }
}
/*class tableDesign
{  public int materials { get; set; }
    public decimal breadth { get; set; }
    public decimal length { get; set; }
    public string colour { get; set; }
    public double price { get; set; }

    double perimeterOfTop(int breadth,int length)
    { return  (2*(breadth+length));
    }
    double productionCost(int material,double tPrice)
    { return materials*tPrice; }
    double Area(int breadth,int length) {
        return breadth * length;

    }
}
*/

    class LoanApplicant
{
    double accountNumber { get; set; }
    string accountName { get; set; }
    double accountBalance { get; set; }

   bool qualified(int accountbalance,int balanceRequired)
    {
        return accountbalance > balanceRequired;
    }
    int Interest(int LoanAmount,int interestRate) {
        int interest=LoanAmount*interestRate;
        return interest;
    }
    DateTime whenDue(DateTime whenCollected)
    {

        DateTime Due=DateTime.Now.AddDays(40);
        return Due;
    }
    


}