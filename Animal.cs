using System;
class Animal
{

    private int Age { get; set; }

    protected string Name { get; set; }

    public string Owner { get; set; }

    public Animal()
    {
        System.Console.WriteLine("odatiy constructor");
        
    }

    static Animal()
    {
        System.Console.WriteLine("static constructor ishlayapti");
    }
}