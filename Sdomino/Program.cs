using System.IO;
using Inventory;

var calcolo= new Calcolo();
var ingredienti = new Ingredienti();
var order = new Order();

var files = File.Create(@"C:\Users\student\Desktop\projects_ACCADEMY22\\test.txt");
var directoryInfo = Directory.GetFiles("C:\\Users\\student\\Desktop\\projects_ACCADEMY22\\test.txt");

System.IO.File.WriteAllText(@"C:\Users\student\Desktop\projects_ACCADEMY22\\test.txt", "BEN FATTO");
var counter = 1;
foreach (var file in directoryInfo)
{
    var orderedId = $"order {counter++}";
    var orderLines = File.ReadAllLines("C:\\Users\\student\\Desktop\\projects_ACCADEMY22\\test.txt");
    var dir = File.ReadAllLines(file);
    
    foreach (var line in orderLines)
    {
        var pizzacomponents =line.Split(';');
        var tipopizza=pizzacomponents[0];
        var impasto = pizzacomponents[1];
        var componenti = pizzacomponents[2].Split(',');
        var totale =0;
    }
}
Console.WriteLine("Buon Appetito");
