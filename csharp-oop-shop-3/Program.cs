using csharp_oop_shop_3;

Water water = new Water("panna", "podco", 22, 4, 1.7, 12, "osf");

try
{
    water.GetProductString();
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}