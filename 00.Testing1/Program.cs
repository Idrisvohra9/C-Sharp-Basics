using System;
class Home
{
    public Home()
    {
        Console.WriteLine("Simple constructor called.");
    }
    ~Home()
    {
        Console.WriteLine("Destructer called.");
    }
}

class Complex
{

    // Class members, private 
    // by default
    int real, img;

    // Defining the constructor
    public Complex()
    {
        real = 0;
        img = 0;
    }

    // SetValue method sets 
    // value of real and img
    public void SetValue(int r, int i)
    {
        real = r;
        img = i;
    }

    // DisplayValue displays 
    // values of real and img
    public void DisplayValue()
    {
        Console.WriteLine("Real = " + real);
        Console.WriteLine("Imaginary = " + img);
    }

    // Defining the destructor
    // for class Complex
    ~Complex()
    {
        Console.WriteLine("Destructor was called");
    }

} // End class Complex


class Program
{

    static void Main(string[] args)
    {
        Home h = new Home();
        Complex c = new Complex();
        c.SetValue(10, 02);
        c.DisplayValue();
        
        
    }
}