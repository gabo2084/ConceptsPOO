// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

try
{
    Console.WriteLine(new Date(2022,5,18));
    Console.WriteLine(new Date(2024, 2, 29));

}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
