using csharp_oop_shop_3;

try
{
    Water water = new Water("San Pellegrino", "Acqua Frizzante", 1.20, 4, 1, 7, "San Pellegrino");
    Console.WriteLine(water);
    water.RefillWater(4);
}
catch (Exception e)
{
    Console.WriteLine("Qualcosa è andato storto.. " + e.Message);
}