Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");

Console.WriteLine($"My dog's name is {myDog._name}.");
Console.WriteLine($"My neighbour's dog's name is {neighboursDog._name}.");

class Dog
{
    public string _name;
    public int _levelOfHapiness;

    // Constructor
    public Dog(string name) // name - lets the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }
}