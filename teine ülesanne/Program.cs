Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");

Console.WriteLine($"My dog's name is {myDog.Name}.");
Console.WriteLine($"My neighbour's dog's name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

class Dog
{
    private string _name; // field
    private int _levelOfHapiness;

    // Constructor
    public Dog(string name) // name - lets the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    // Property to access the name
    public string Name
    {
        get { return _name; }
    }

    // Method to rename the dog
    public void Rename(string newName)
    {
        _name = newName;
    }
}
