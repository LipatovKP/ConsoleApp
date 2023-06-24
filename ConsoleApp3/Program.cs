Person tom = new();
Person bob = new("Bob");
Person sam = new("Sam", 25);

tom.Print();    // !!!! Имя:   Возраст: 0
bob.Print();    // Имя: Bob  Возраст: 1 
sam.Print();    // Имя: Sam  Возраст: 25

struct Person
{
    public string name;
    public int age;

    public Person(string name = "Tom", int age = 1)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}
