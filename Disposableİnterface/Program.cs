


List<EntityLayer1> layers = new List<EntityLayer1>();

for (int i = 11; i <=99; i++)
{

    EntityLayer1 entity = new EntityLayer1 { id = i, Name = "asdfsdf", Number = i };

    layers.Add(entity);
}

Thread.Sleep(100);

foreach (var layer in layers)
{
    Console.WriteLine($"Id = {layer.id} --- Number = {layer.Number} --- Name = {layer.Name}");
    
}
public class EntityLayer1
{
    public int id { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
}