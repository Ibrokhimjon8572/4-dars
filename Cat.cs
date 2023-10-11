class Cat : Animal
{
    public void SomeFunc()
    {
        System.Console.WriteLine(Owner, Name);
    }

    static Cat()
    {
        System.Console.WriteLine("cat static construktor ishladi");
    }

    public Cat()
    {
        System.Console.WriteLine("cat odatiy ishladi");
    }
}

class Dog: Cat
{
    public void SomeFunc1()
    {
        System.Console.WriteLine(Owner, Name);
    }
    static Dog()
    {
        System.Console.WriteLine("dog static construktor ishladi");
    }

    public Dog()
    {
        System.Console.WriteLine("dog odatiy ishladi");
    }
}
