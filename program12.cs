//Write a program to create a interface Bank having method ROI.Create a class HDFC, ICICI & SBI that will implement the interface method

using System;
interface Bank
{
    public void roi();
}
class ICICI : Bank
{
    public void roi()
    {
        Console.WriteLine("Interest rate is 7%");
    }
}
class HDFC : Bank
{
    public void roi()
    {
        Console.WriteLine("Interest rate is 6.5%");
    }
}
class SBI : Bank
{
    public void roi()
    {
        Console.WriteLine("Interest rate is 6%");
    }
}
class Test
{
    public static void Main()
    {
        Bank b;
    b = new ICICI();
    b.roi();
    b = new HDFC();
    b.roi();
    b = new SBI();
    b.roi();
    }
}
