using System;
public class Account
{
    public int accno;
    public String name;
    public static string city  = "Mumbai";
    public Account(int accno, String name)
    {
        this.accno = accno;
        this.name = name;
    }

    public void display()
    {
        Console.WriteLine(accno + " " + name + " " + city);
    }
}
class TestStatic
{
    public static void Main(string[] args)
    {
        Account sbi = new Account(1, "Sanjay");
        Account pnb = new Account(2, "Rahul");
        sbi.display();
        pnb.display();

    }
}