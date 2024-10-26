
Random random = new Random();

for (int i = 0; i <1000;i++)
{
    var result = random.Next(10,100);
    if (result == 10 || result == 99)
    {
        Console.WriteLine($"10 yada 99 {result}");
    }
    if (result == 100|| result == 9)
    {
        Console.WriteLine("olmadı");
    }


}
public class EntityLayer1
{
    public int id { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
}