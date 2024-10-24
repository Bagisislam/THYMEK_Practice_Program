


using Newtonsoft.Json;

string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

// Define the relative path for the JSON file
string filePath = Path.Combine(appDirectory, "Theİtems.json");


if (File.Exists(filePath) == false)
{

    Console.WriteLine(@"C:\\Users\\gsli_\\source\\repos\\THYMEK_Practice_Program\\Disposableİnterface\\Theİtems.json");

    Console.WriteLine(filePath);

    Console.WriteLine("olmadı amın oglu");

    Console.ReadLine();

}


var json = File.ReadAllText(filePath);

var items = JsonConvert.DeserializeObject<List<EntityLayer1>>(json);

foreach (var item in items)
{
    Console.WriteLine($"ID: {item.id}, Name: {item.Name}, Number: {item.Number}");
}
public class EntityLayer1
{
    public int id { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
}