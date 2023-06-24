using Newtonsoft.Json;

using ConsoleInterface;


var cars = new List<ICar>();
cars.Add(new LadaSeven());
cars.Add(new BMWSeven());
BMWSeven bMWSeven = new BMWSeven();

foreach (var car in cars)
{
    Console.WriteLine(car.Move(200)); 
}

Console.WriteLine(new String('-',50));

Cyborg cyborg = new Cyborg();
((ICar)cyborg).Move(100);
((IPerson)cyborg).Move(100);
Console.WriteLine();
((ICar)bMWSeven).Move(300);