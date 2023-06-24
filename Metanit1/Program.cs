using MyLib;

Person tom = new("Kirill");
tom.Print();
//Person p = new Person {name = "Tom", age = 23 };
//// C (ref p) можно изменить поля. свойства.объект
//ChangePerson( p);


//Console.WriteLine(p.name);// Alice
//Console.WriteLine(p.age);// 23

//// C (ref Person person) можно изменить поля. свойства.объект
//void ChangePerson( Person person)
//{
//    // Сработает
//    person.name = "Alice";
//    // Сработает в рамках метода
//    person = new Person { name = "Bill", age = 45 };
//    Console.WriteLine(person.name);// Bill
//}

//class Person
//{
//    public string name = "";
//    public int age;
//}
