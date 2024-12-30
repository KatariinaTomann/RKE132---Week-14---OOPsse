using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Name your dog:");
        string myDogName = Console.ReadLine();
        Dog myDog = new Dog(myDogName);

        Dog neighboursDog = new Dog("Good Girl");

        Console.WriteLine($"My dog's name is {myDog.Name}.");
        Console.WriteLine($"My neighbour's dog's name is {neighboursDog.Name}.");

        myDog.Rename("Bad Boy");

        while (myDog.LevelOfHappiness != 5)
        {
            myDog.Bark();
        }

        myDog.WagTail();
    }
}

class Dog
{
    private string _name; // Field
    private int _levelOfHappiness; // Field

    // Constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    // Getter for Name
    public string Name
    {
        get { return _name; }
    }

    // Getter for LevelOfHappiness
    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    // Rename method
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    // Bark method
    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    // WagTail method
    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}
